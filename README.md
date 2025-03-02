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

<h2>مدیریت PickRepository :</h2>
<h3>افزودن کلاس :</h3>
<h4>برای افزودن کلاس دیگر فقط باید قطعه کد زیر را به فایل اضافه کنید و تنها کافیست ShopNameRepository<نام کلاس> را تغییر دهید</h4>
<h5>private ShopNameRepository<FAQ> _faqRepository; <br />
public ShopNameRepository<FAQ> FaqRepository <br />
{ <br />
    get <br />
    { <br />
        if (_faqRepository==null) <br />
        { <br />
            _faqRepository = new ShopNameRepository<FAQ>(_db); <br />
        } <br />
        return _faqRepository; <br />
    } <br />
}</h5> <br />
