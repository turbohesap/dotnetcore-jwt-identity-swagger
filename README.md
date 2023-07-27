### Dotnet Core identity ile kullanıcı kayıt ve giriş işlemleri
### Kullanılan teknolojiler
- Dotnet Core 7.0
- Entity Framework Core
- sqlite

### Kullanılan paketler
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.AspNetCore.OpenApi
- Microsoft.EntityFrameworkCore.Design
- Swashbuckle.AspNetCore

### Örneği çalıştırmak için
- Projeyi indirin
- Veya **git clone git@github.com:turbohesap/dotnetcore-jwt-identity-swagger.git** komutu ile projeyi klonlayın
- **dotnet restore** komutu ile paketleri yükleyin
- **dotnet ef database update** komutu ile veritabanını oluşturun
- **dotnet run** komutu ile projeyi çalıştırın
- **https://localhost:5001/swagger/index.html** adresinden api dökümantasyonuna ulaşabilirsiniz

### Kullanım
- Öncelikle  **/Api/Auth/Register** veya **/Api/Auth/RegisterAdmin** adreslerinden kullanıcı oluşturun
- Daha sonra **/Api/Auth/Login** adresinden giriş yapın
- Tokenizi swagger arayüzünden bulunan **Authorize** butonuna tıklayarak **Bearer** olarak ekleyin
- **Bearer** **token** formatı şeklinde ekleyin(Başa bearer yazmayı unutmayın)
- Artık diğer endpointlere erişebilirsiniz
- User rolü ile Api/Test/User adresine erişip /Api/Test/Admin adresine erişemezsiniz
- Admin rolü ile her ikisine de erişebilirsiniz
