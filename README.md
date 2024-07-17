# Chain-of-responsibility-pattern
Chain of Responsibility tasarım deseni, bir isteğin bir dizi işleyici nesnesi tarafından işlenmesini sağlayan davranışsal bir tasarım desenidir. Bu desen, isteği bir işleyici zinciri boyunca yönlendirir ve zincirdeki her işleyici, isteği işleyip işlememeye karar verir. İşleyici isteği işleyemezse, bir sonraki işleyiciye iletir.

![chain-of-responsibility](https://github.com/user-attachments/assets/cef8463d-64ba-45dd-a388-5797e28cf0a0)

<h1>Ne gibi sorunlar çıkabilir?</h1>
<p>Bazı isteklerin hangi işleyici tarafından işleneceğini belirlemenin karmaşık ve esnek bir yöntemi gerektiğinde, tek bir işleyiciye bağımlı kalmak zor olabilir. Bu durum, özellikle çeşitli işleme mantıkları gerektiren karmaşık işlemler söz konusu olduğunda ortaya çıkar. Örneğin, bir müşteri hizmetleri uygulamasında, farklı türdeki müşteri şikayetleri farklı departmanlara yönlendirilmelidir. Her departmanın kendi işleyiş kuralları vardır ve bazı şikayet türleri birden fazla departmanın ilgisini gerektirebilir. İşleme mantığını merkezi bir yerde toplamak, kodun bakımını zorlaştırır ve esnekliğini azaltır.</p>
<br/><br/>
<h1>Çözüm</h1>
<p>Chain of Responsibility deseni, isteği işleme sürecini dinamik ve esnek hale getirmek için işleyicileri bir zincir şeklinde düzenler. Bu desen, her işleyicinin isteği işleyip işlemeyeceğine karar verebilmesi ve işleyemezse bir sonraki işleyiciye iletmesi prensibiyle çalışır. Bu sayede, bir isteğin hangi işleyici tarafından ele alınacağı önceden belirlenmek zorunda kalmaz ve işleyiciler zinciri üzerinde dinamik olarak belirlenir. İşleyici zincirine yeni işleyiciler eklemek veya mevcut işleyicileri değiştirmek kolaydır, bu da sistemi daha esnek ve bakımını daha kolay hale getirir.

Örnek:
Bir müşteri hizmetleri uygulamasında, müşteri şikayetleri farklı işleyicilere yönlendirilir. Örneğin, teknik destek, faturalama ve genel müşteri hizmetleri gibi farklı departmanlar, şikayetlerin türüne göre sırayla şikayetleri ele alır. Bir şikayet önce teknik destek işleyicisine gönderilir ve eğer bu işleyici şikayeti çözemiyorsa, faturalama işleyicisine iletilir. Eğer o da çözemiyorsa, genel müşteri hizmetleri işleyicisine iletilir. Bu yapı, şikayetlerin doğru departman tarafından ele alınmasını sağlar ve işleyiciler arasındaki iş akışını düzenler. Böylece, işleyicilerin işleme mantığı merkezi bir yerden yönetilmek yerine dağıtılmış olur, sistem daha modüler ve yönetilebilir hale gelir.</p>

![solution1-en](https://github.com/user-attachments/assets/ae27103d-2c82-4ceb-905b-fb98cdd053fb)

Bir nesne ağacının bir dalından bir zincir oluşturulabilir.

![solution2-en](https://github.com/user-attachments/assets/8ed204d1-993e-4cf8-9a1b-20531906a219)

Chain of Responsibility deseninde, tüm işleyici sınıflarının aynı arayüzü uygulaması çok önemlidir. Bu yaklaşım, işleyicilerin bir zincir boyunca tutarlı bir şekilde çalışmasını sağlar ve kodun yeniden kullanılabilirliğini artırır. Arayüz, işleyicilerin uyması gereken bir sözleşme gibidir ve her işleyicinin bu sözleşmeyi yerine getirmesi beklenir.


