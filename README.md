# BasicRepository
Create a basic repository for ASP.Net MVC sites
<br />
<br />
<br />
<h2>فایل GenericRepository :</h2>
<h4>کلاس هایی وجود دارند که عملیات CRUD را انجام میدهند.</h4>
<br />
<h2>فایل PickRepository :</h2>
<h4>کلاس هایی وجود دارند که به ما اجازه میدهند از کلاس هایی که میخواهیم در آنها از ریپازیتوری استفاده کنیم را مدیریت کنیم و در طول اجرای برنامه از نمونه سازی اضافی کلاس Context جلوگیری میکند</h4>
<hr>
<h2>مدیریت PickRepository :</h2>
<h3>افزودن کلاس :</h3>
<h4>برای افزودن کلاس دیگر فقط باید قطعه کد زیر را به فایل اضافه کنید و تنها کافیست ShopNameRepository<نام کلاس> را تغییر دهید</h4>
<h4>میتوانید برای قابل فهم تر شدن برنامه نام ریپازیتوری را با نام کلاس یکی کنید</h4>
<pre>private ShopNameRepository<نام کلاس> _nameRepository;
public ShopNameRepository<نام کلاس> NameRepository
{
    get
    { 
        if (_nameRepository==null)
        {
            _nameRepository = new ShopNameRepository<نام کلاس>(_db);
        }
        return _nameRepository;
    }
}</pre>
<h4>یک نمونه از کد ویرایش شده (کلاس : User)</h4>
<pre>private DigiRepository<User> _userRepository;
public DigiRepository<User> UserRepository
{
    get
    { 
        if (_userRepository==null)
        {
            _userRepository = new DigiRepository<User>(_db);
        }
        return _userRepository;
    }
}</pre>
                <br />
<h3>حذف کلاس :</h3>
<h4>برای حذف کلاس فقط کافیست قطعه کد مربوط به آن را حذف کنید و به این ترتیب دیگر امکان استفاده از ریپازیتوری برای آن کلاس نخواهد بود</h4>
