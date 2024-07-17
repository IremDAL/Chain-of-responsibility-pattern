# Chain-of-responsibility-pattern
Chain of Responsibility tasarım deseni, bir isteğin bir dizi işleyici nesnesi tarafından işlenmesini sağlayan davranışsal bir tasarım desenidir. Bu desen, isteği bir işleyici zinciri boyunca yönlendirir ve zincirdeki her işleyici, isteği işleyip işlememeye karar verir. İşleyici isteği işleyemezse, bir sonraki işleyiciye iletir.

![chain-of-responsibility](https://github.com/user-attachments/assets/cef8463d-64ba-45dd-a388-5797e28cf0a0)

<h1>Ne gibi sorunlar çıkabilir?</h1>
<p>Bazı isteklerin hangi işleyici tarafından işleneceğini belirlemenin karmaşık ve esnek bir yöntemi gerektiğinde, tek bir işleyiciye bağımlı kalmak zor olabilir. Bu durum, özellikle çeşitli işleme mantıkları gerektiren karmaşık işlemler söz konusu olduğunda ortaya çıkar. Örneğin, bir müşteri hizmetleri uygulamasında, farklı türdeki müşteri şikayetleri farklı departmanlara yönlendirilmelidir. Her departmanın kendi işleyiş kuralları vardır ve bazı şikayet türleri birden fazla departmanın ilgisini gerektirebilir. İşleme mantığını merkezi bir yerde toplamak, kodun bakımını zorlaştırır ve esnekliğini azaltır.</p>
<br/><br/>
<h1>Çözüm</h1>
<p>Chain of Responsibility deseni, bu sorunu çözmek için işleyicileri bir zincir şeklinde düzenler. Her işleyici, isteği işleme veya bir sonraki işleyiciye yönlendirme kararını verir. Bu şekilde, isteğin hangi işleyici tarafından işleneceği dinamik olarak belirlenir ve zincire yeni işleyiciler eklemek veya mevcut işleyicileri değiştirmek kolaylaşır. Bu desen, kodun esnekliğini artırır ve işleme mantığını daha modüler ve bakımı kolay hale getirir.</p>
<br/><br/>
<p>Örneğin, bir müşteri hizmetleri uygulamasında, müşteri şikayetleri zincirdeki farklı işleyicilere yönlendirilir. Şikayet türüne bağlı olarak, şikayetler farklı departmanlara (örneğin, teknik destek, faturalama, genel müşteri hizmetleri) iletilir. Her departman, şikayeti işleyebilir veya bir sonraki departmana yönlendirebilir. Bu yapı, şikayetlerin doğru şekilde işlenmesini sağlar ve işleyicilerin işleme mantığını merkezi bir yerden yönetmek yerine dağıtır.</p>
![solution1-en](https://github.com/user-attachments/assets/ae27103d-2c82-4ceb-905b-fb98cdd053fb)
