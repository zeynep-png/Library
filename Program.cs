using Library;

//Create a book ogject using the default constructor
Book book1 = new Book();
book1.BookName = "Bir Kitap";
book1.WriterFirstName = "Ahmet";
book1.WriterLastName = "Yılmaz";
book1.PaperCount = 320;
book1.Publisher = "Alfa Yayınları";
//Print the details of the first book using the Show method
book1.Show();

//Create more book objects using the parameterized constructor
Book book2 = new Book("Başka Bir Kitap","Ayşe","Karan",215,"Beta Yayıncılık");
book2.Show();
Book book3 = new Book("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gamma Yayınları");
book3.Show();
Book book4 = new Book("Son Kitap", "Elif", "Şahin", 275, "Delta Yayıncılık");
book4.Show();
Book book5 = new Book("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");
book5.Show();


//Class belirli bir nesnenin yapısını ve davranışlarını tanımlayan bir şablondur. Fields, properties ve methods içerir.

//Property bir class ın özelliklerini(fields) dış dünyaya sunmak için kullanılan yapıdır. Get set metodları ile atama ve değer döndürme yapılır.

//New anahtar kelimesi bir sınıfın yeni bir örneğini (instance) oluşturmak için kullanılır.

//Constructor bir sınıfın yeni bir örneği oluştuğunda çağrılan özel bir metottur. Sınıfın başlangıç değerini ayarlar. Parametre alabilir veya almayabilir.

