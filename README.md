# RabbitMQ Example for tutorial
<strong>.net core webapi and .net core consoleapplication<strong>

### <b>install</b> 'RabbitMQ.Client' (https://www.nuget.org/packages/RabbitMQ.Client)

<h2>RabbitMQ Terms</h2>

En: Producer (Publisher) <code style="color : green">The party that creates, sends or provides the message.</code>
<br/><br/>
Tr: Producer (Publisher) <code style="color : green">Mesajı oluşturan, gönderen veya sağlayan taraftır.</code>

En: Consumer:  <code style="color : green">It is the consuming party that receives and processes data from the "queue" it subscribes to.</code><br/><br/>
Tr: Consumer:  <code style="color : green">Abone olduğu “queue” dan veriyi alıp işleyen tüketen taraftır.</code>

En: Queue :  <code style="color : green">The queue to which the message is attached and subscribed by the Consumer.</code><br/><br/>
Tr: Queue:  <code style="color : green">Mesjın eklendiği ve Consumer tarafından abone olan kuyruktur.</code><br/>

En: Exchange:  <code style="color : green">Used as an intermediary for forwarding the message. The message transmitted to "exchance" by the producer is forwarded to the queue with the help of Exchange type (Header attribute), binding and routing key.</code><br/><br/>
Tr: Exchange:  <code style="color : green">Mesajı yönlendirme için aracı olarak kullanılır. Producer tarafından “exchance” e iletilen mesaj, Exchange type(Header attribute), binding ve routing key yardımı ile queue iletmektedir.</code><br/>

En: Exchange Type:  <code style="color : green">Specifies how and to which “queue” the message will be forwarded.</code><br/><br/>
Tr: Exchance Type:  <code style="color : green">Mesajın hangi “queue”ya ne şekilde iletileceğini belirtir.</code>

En: Binding:  <code style="color : green">It is the connection between Exchange and queue.</code><br/><br/>
Tr: Binding:  <code style="color : green">Exchance ve queue arasındaki bağlantıdır</code>.<br/>
<hr/>

<h2>Queue Properties</h2>

En: Name:  <code style="color : green"> The name of the queue we defined.</code><br/><br/>
Tr: Name:  <code style="color : green"> Tanımlamış olduğumuz kuyruğun adı.</code>

En: Durable:  <code style="color : green"> Related to the lifetime of the queue. If we want persistence, we must set true. For our example, we will be creating in-memory. In this case, the queue will be deleted when the broker restarts.</code><br/><br/>
Tr: Durable:  <code style="color : green"> Kuyruğun yaşam süresi ile alakalı. Eğer persistence olmasını istersek true set etmeliyiz. Biz örneğimiz için in-memory olacak şekilde oluşturuyor olacağız. Bu durumda broker restart olduğununda queue silinmiş olacak.</code>

En: Exclusive:  <code style="color : green"> Contains information whether the queue will be used with other connections.</code><br/><br/>
Tr: Exclusive:  <code style="color : green"> Kuyruğun başka connectionlar ile birlikte kullanıp kullanılmayacağı bilgisini içerir.</code>

En: AutoDelete:  <code style="color : green"> It contains information about deleting the queue as the data sent to the queue passes to the consumer side.</code><br/><br/>
Tr: AutoDelete:  <code style="color : green"> Kuyruğa gönderilen veri consumer tarafına geçmesi ile birlikte kuyruğun silinmesi ile ilgili bilgiyi içerir.</code>
<br/><br/>
Docker install and run : 'docker run -d --hostname rabbit --name rabbit rabbitmq:3-management' (default username = 'guest', password = 'guest')
