using DataLayer.Repositories;
using DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ShopNameDB
    {
        private Context _db;

        public ShopNameDB()
        {
            _db = new Context();

        }

        private ShopNameRepository<FAQ> _faqRepository;
        public ShopNameRepository<FAQ> FaqRepository
        {
            get
            {
                if (_faqRepository==null)
                {
                    _faqRepository = new ShopNameRepository<FAQ>(_db);
                }
                return _faqRepository;
            }
        }
        
        private ShopNameRepository<User> _userRepository;
        public ShopNameRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new ShopNameRepository<User>(_db);
                }
                return _userRepository;
            }
        }
        
        private ShopNameRepository<Role> _roleRepository;
        public ShopNameRepository<Role> RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new ShopNameRepository<Role>(_db);
                }
                return _roleRepository;
            }
        }
        
        private ShopNameRepository<Blog> _blogRepository;
        public ShopNameRepository<Blog> BlogRepository
        {
            get
            {
                if (_blogRepository == null)
                {
                    _blogRepository = new ShopNameRepository<Blog>(_db);
                }
                return _blogRepository;
            }
        }
        private ShopNameRepository<Brand> _brandRepository;
        public ShopNameRepository<Brand> BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new ShopNameRepository<Brand>(_db);
                }
                return _brandRepository;
            }
        }
        
        private ShopNameRepository<Category> _categoryRepository;
        public ShopNameRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new ShopNameRepository<Category>(_db);
                }
                return _categoryRepository;
            }
        }
        
        private ShopNameRepository<Gallery> _galleryRepository;
        public ShopNameRepository<Gallery> GalleryRepository
        {
            get
            {
                if (_galleryRepository == null)
                {
                    _galleryRepository = new ShopNameRepository<Gallery>(_db);
                }
                return _galleryRepository;
            }
        }
        
        private ShopNameRepository<Message> _messageRepository;
        public ShopNameRepository<Message> MessageRepository
        {
            get
            {
                if (_messageRepository == null)
                {
                    _messageRepository = new ShopNameRepository<Message>(_db);
                }
                return _messageRepository;
            }
        }
        
        private ShopNameRepository<Product> _productRepository;
        public ShopNameRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ShopNameRepository<Product>(_db);
                }
                return _productRepository;
            }
        }
        private ShopNameRepository<Property> _propertyRepository;
        public ShopNameRepository<Property> PropertyRepository
        {
            get
            {
                if (_propertyRepository == null)
                {
                    _propertyRepository = new ShopNameRepository<Property>(_db);
                }
                return _propertyRepository;
            }
        }
        private ShopNameRepository<ProductProperty> _ProductPropertyRepository;
        public ShopNameRepository<ProductProperty> ProductPropertyRepository
        {
            get
            {
                if (_ProductPropertyRepository == null)
                {
                    _ProductPropertyRepository = new ShopNameRepository<ProductProperty>(_db);
                }
                return _ProductPropertyRepository;
            }
        }



        public void Save()
        {
            _db.SaveChangesAsync();
        }

    }
}
