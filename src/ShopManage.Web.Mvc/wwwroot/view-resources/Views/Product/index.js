(function () {
    $(function () {

        var _productService = abp.services.app.product;
        var _$modal = $('#ProductCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        $('#RefreshButton').click(function () {
            refreshProductList();
        });

        $('.delete-product').click(function () {
            var productId = $(this).attr("data-product-id");
            var tenancyName = $(this).attr('data-tenancy-name');

            deleteProduct(productId, tenancyName);
        });

        $('.edit-product').click(function (e) {
            var productId = $(this).attr("data-product-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Product/EditProductModal?productId=' + productId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#ProductEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        //添加
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            //验证
            if (!_$form.valid()) {
                return;
            }

            var dto = _$form.serializeFormToObject(); //序列化表单对象
            //dto.Code = null;
            //dto.Barcode = null;
            //dto.Picture = "http://p2.wmpic.me/article/2016/09/19/1474265209_uDMIqejD.jpg";
            //dto.CategoryId = 1;
            //dto.CommentTimes = 0;
            //dto.SoldNum = 0;
            var data = {
                productEditDto: {
                    Id: dto.Id,
                    Code: null,
                    Barcode: dto.Barcode,
                    Price: 11,
                    OldPrice: 15,
                    ShortName: dto.ShortName,
                    Name: dto.Name,
                    Size: dto.ShortName,
                    ShortDescription: "",
                    FullDescription: "",
                    Picture: "http://p2.wmpic.me/article/2016/09/19/1474265209_uDMIqejD.jpg",
                    Status: 1,
                    CategoryId: 1,
                    IsBest: 1,
                    IsNew: 1,
                    CommentTimes: 30,
                    SoldNum: 20
                }
            }

            abp.ui.setBusy(_$modal);//避免重复提交
            //约定大于配置
            _productService.createOrUpdateProduct(data).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new product!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshProductList() {
            location.reload(true); //reload page to see new product!
        }

        function deleteProduct(productId, tenancyName) {
            abp.message.confirm(
                "Delete product '" + tenancyName + "'?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _productService.delete({
                            id: productId
                        }).done(function () {
                            refreshProductList();
                        });
                    }
                }
            );
        }
    });
})();