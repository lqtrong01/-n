using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CategoryBUS
    {

        CategoryDAO _categoryDAO = new CategoryDAO();

        // Phương thức lấy danh sách Khách Hàng
        public List<CategoryDTO> ShowListCategory()
        {
            // Xử lý dữ liệu ....


            return _categoryDAO.ShowListCategory();
        }

        // Phương thức thêm Khách Hàng mới

        public bool AddCategory(CategoryDTO newCategory)
        {
            // Kiểm tra khách hàng tông tại ? Them SDT
            if (_categoryDAO.IsExisted(newCategory)) return false;

            // thực hiện việc thêm khách hàng mới
            return _categoryDAO.AddCategory(newCategory);

        }
        public bool DeleteCategory(CategoryDTO newCategory)
        {
            // Kiểm tra khách hàng tông tại ? Them SDT
            if (_categoryDAO.IsExisted(newCategory)) return false;

            // thực hiện việc thêm khách hàng mới
            return _categoryDAO.DeleteCategory(newCategory);

        }

        // Phương thức xóa Khách Hàng theo mãKH

        // Phương thức cập nhật thông tin Khách Hàng theo mãKH
    }
    public class ProductBUS
    {
        ProductDAO _productDAO = new ProductDAO();
        // Phương thức lấy danh sách Khách Hàng
        public List<ProductDTO> ShowListProduct()
        {
            // Xử lý dữ liệu ....


            return _productDAO.ShowListProduct();
        }

        // Phương thức thêm Khách Hàng mới

        public bool AddProduct(ProductDTO newProduct)
        {
            // Kiểm tra khách hàng tông tại ? Them SDT
            if (_productDAO.IsExisted(newProduct)) return false;

            // thực hiện việc thêm khách hàng mới
            return _productDAO.AddProduct(newProduct);

        }
        public bool DeleteProduct(ProductDTO newProduct)
        {
            if(_productDAO.IsExisted(newProduct)) return false ;

            return _productDAO.AddProduct(newProduct);
        }
    }
}
