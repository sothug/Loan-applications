# Система приёма заявок на кредит
## `Содержание`
[Введение](#introduction)  
1 [Описание](#description)  
2 [Существующие решения](#existing)  
3 [Разработка](#development)  
3.1 [Проектирование](#design)  
3.2 [Реализация](#realization)  
4 [Тестирование](#testing)    
[Заключение](#conclusion)  
[Список использованных источников](#bibliography)  

<div style="page-break-after: always"></div>
## Введение <a name="introduction"></a>

В данном отчёте рассматривается разработка "Системы приёма заявок на кредит". Система предназначена для создания и просмотра информации о заявках на кредит.

Обслуживание клиентов, которые хотят оформить кредит, должно проходить быстро, тем самым и регистрация клиента должна оформляться быстро.

## 1 Описание <a name="description"></a>

Предметная область, подлежащая изучению - «банк», в частности «кредитование». В сферу этой предметной области попадают финансово-кредитные учреждения, производящие разнообразные виды операций с деньгами и ценными бумагами. Цель функционирования учреждений этой предметной области - безопасное хранение денег, безналичные переводы от одного клиента к другому, выдача кредитов. Для оказания услуг необходимо наличие квалифицированных специалистов, хранилищ, помещений, удовлетворяющих нормам санитарных и других требований в соответствии с действующим законодательством.

Кредит или кредитные отношения - общественные отношения, возникающие между субъектами экономических отношений по поводу движения стоимости. Кредитные отношения могут выражаться в разных формах кредита (коммерческий кредит, банковский кредит и др.), займе, лизинге, факторинге и т. д.

Возникновение кредита как особой формы стоимостных отношений происходит тогда, когда стоимость, высвободившаяся у одного экономического субъекта, какое-то время не вступает в новый воспроизводственный цикл. Благодаря кредиту она переходит от субъекта, не использующего её (кредитор), к другому субъекту, испытывающему потребность в дополнительных средствах (заёмщик).

Загруженность банков иногда имеет пиковый характер. Эту загруженность можно снизить путём внедрения.

> Минкомсвязь предложила обязать владельцев элементов, входящих в критическую информационную инфраструктуру (КИИ), «преимущественно использовать» российское программное обеспечение с 1 января 2021 года и российское оборудование — с 1 января 2022 года[<sup>[1]</sup>](#sourse_1)[<sup>[2]</sup>](#sourse_2).

## 2 Существующие решения <a name="existing"></a>

Рассмотрим два программных продукта: Сбербанк[<sup>[3]</sup>](#sourse_3) и ВТБ[<sup>[4]</sup>](#sourse_4).

Сбербанк - крупнейший универсальный банк России, является самым востребованным банком среди розничных клиентов. К преимуществам можно отнести следующие вещи:

- оформление за 5 минут;
- нужен только паспорт;
- страховка, по желанию.

ВТБ - второй крупнейший банк России по объёмам розничного бизнеса. Преимущества:

- оформление за 5 минут;
- возможность заполнить заявку быстрее с помощью госуслуг.

## 3 Разработка <a name="development"></a>

В данной главе будет рассмотрено создание приложения проектируемой информационной системы. Данный вид технологии крайне удобен тем, что данные хранятся не в среде, с которой взаимодействует пользователь. Это повышает уровень безопасности данных и предотвращается шанс их потери.

## 3.1 Проектирование <a name="design"></a>

Разработка информационной системы начинается с проектирования диаграммы сценариев использования (Use Case), отражающей действующие лица данной системы (см. [рисунок 1](#figure_1)).
<a name="figure_1">
    <p align="center">
        <img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Use%20Case.drawio.svg"><br>
        Рисунок 1 - Диаграмма сценариев использования
    </p>
</a>

На основе Use Case разрабатывается диаграмма потоков данных (Data Flow), которая наглядно отображает течение информации в пределах системы (см. [рисунок 2](#figure_2)).
<a name="figure_2">
    <p align="center">
        <img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Data%20Flow.drawio.svg"><br>
        Рисунок 2 - Диаграмма потоков данных
    </p>
</a>

На основе Data Flow разрабатывается диаграмма отношений сущностей (Entity Relationship), на которой показано, как разные сущности взаимодействуют внутри системы (см. [рисунок 3](#figure_3)). К сущностям относятся люди, различные объекты, концепции и т.д.
<a name="figure_3">
    <p align="center">
        <img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Entity%20Relationship-Page-1.drawio.svg"><br>
        Рисунок 3 - Диаграмма отношений сущностей
    </p>
</a>

ER-диаграмма (см. [рисунок 3](#figure_3)) отражает отношения между сущностями, но не показывает, каких типов должны быть поля, поэтому была сделана физическая модель данных (см. [рисунок 4](#figure_4)).
<a name="figure_4">
    <p align="center">
        <img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Entity%20Relationship-Page-2.drawio.svg"><br>
        Рисунок 4 - Физическая модель данных
    </p>
</a>

## 3.2 Реализация <a name="realization"/>

На основе физической модели данных были созданы классы. Ниже приведен пример класса Кредитополучатель (см. [листинг 1](#listing_1)).  
<a name="listing_1"></a>Листинг 1 - Класс "Кредитополучатели"
```csharp
    public class Client : IIdentifier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkAdress { get; set; }
        public string PositionAtWork { get; set; }
        public int Income { get; set; }
    }
```

В описании данного класс, как и в описании всех остальных классов, присутствует класс-предок "IIdentifier" (см. [листинг 2](#listing_2)), предназначение которого объясняется далее.  
<a name="listing_2"></a>Листинг 2 - Интерфейс "IIdentifier"
```csharp
    public interface IIdentifier
    {
        public int Id { get; set; }
    }
```

Поскольку методы CRUD для всех сущностей одинаковы, описывать класс хранилищ для каждой сущности не очень рационально, поэтому было принято решение определить шаблонный класс хранилища (см. [листинг 3](#listing_3)). Нижу представлен листинг для общего хранилища (см. [листинг 4](#listing_4)).  
<a name="listing_3"></a>Листинг 3 - Шаблонный класс "Storage"
``` csharp
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static readonly string FilePath = "Storages/" + typeof(TIdentifier).Name + "s.xml";
        private List<TIdentifier> _storage = new();

        public Storage() { }

        public void ReadFromXmlFile()
        {
            if (!File.Exists(FilePath)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(FilePath, FileMode.Open);
            _storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public void SaveToXmlFile()
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
                Directory.CreateDirectory(Path.GetFullPath(FilePath));
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(FilePath, FileMode.Create);
            xs.Serialize(fs, _storage);
            fs.Flush();
        }

        public bool Create(TIdentifier obj) 
        {
            // if (_storage.Where(t => t.ID == obj.ID).Count() != 0)
            if (_storage.Any(t => t.Id == obj.Id))
                return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int id) 
        {
            return _storage.FirstOrDefault(t => t.Id == id);
        }

        public TIdentifier Update(TIdentifier obj) 
        {
            var index = _storage.FindIndex(t => t.Id == obj.Id);
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objId) 
        { 
            return _storage.RemoveAll(t => t.Id == objId) != 0;
        }
    }
```

<a name="listing_4"></a>Листинг 4 - Общее хранилище
``` csharp
    public static class Storages
    {
        public static readonly Storage<Agreement> AgreementStorage = new();
        public static readonly Storage<Application> ApplicationStorage = new();
        public static readonly Storage<Client> ClientStorage = new();
        public static readonly Storage<Dispatcher> DispatcherStorage  = new();
        public static readonly Storage<Manager> ManagerStorage = new();
        public static readonly Storage<Organization> OrganizationStorage = new();
        public static readonly Storage<TypeOfLending> TypeStorage = new();
    }
```

Был разработан набор WEB-методов, включая 4 базисные операции CRUD, для каждой сущности, отражающих предметную область. Примеры контроллеров для классов "Кредитополучатель" (см. [листинг 5](#listing_5)) и "Вид кредитования" (см. [листинг 6](#listing_6)).  
<a name="listing_5"></a>Листинг 5 - Контроллер класса "Кредитополучатель"
``` csharp
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {
        [HttpPost("ChooseType")]
        public string ChooseType(string str)
        {
            return str;
        }

        [HttpPost("ChooseOrganization")]
        public string ChooseOrganization(string str)
        {
            return str;
        }

        [HttpPost("SubmitInformation")]
        public string SubmitInformation(string str)
        {
            return str;
        }

        [HttpPost("Apply")]
        public string Apply(string str)
        {
            return str;
        }

        [HttpPost("Create")]
        public bool Create(Client client)
        {
            return Storages.ClientStorage.Create(client);
        }

        [HttpGet("Read")]
        public Client Read(int ID)
        {
            return Storages.ClientStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Client Update(Client client)
        {
            return Storages.ClientStorage.Update(client);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.ClientStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ClientStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ClientStorage.ReadFromXmlFile();
        }
    }
```

<a name="listing_6"></a>Листинг 6 - Контроллер класса "Вид кредитования"
``` csharp
    [ApiController]
    [Route("/Type")]
    public class TypeController : ControllerBase
    {
        [HttpPost("Create")]
        public bool Create(TypeOfLending typeOfLending)
        {
            return Storages.TypeStorage.Create(typeOfLending);
        }

        [HttpGet("Read")]
        public TypeOfLending Read(int ID)
        {
            return Storages.TypeStorage.Read(ID);
        }

        [HttpPut("Update")]
        public TypeOfLending Update(TypeOfLending typeOfLending)
        {
            return Storages.TypeStorage.Update(typeOfLending);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.TypeStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.TypeStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.TypeStorage.ReadFromXmlFile();
        }
    }
```

## 4 Тестирование <a name="testing"></a>

После запуска программы в режиме отладки открывается страница Swagger UI со списком сущностей и операций над ними (см. [рисунок 5](#figure_5)).  
<a name="figure_5">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146642579-4930314e-0db1-4c60-b8f7-347a2671fae9.png"><br>
        Рисунок 5 - Страница Swagger UI
    </p>
</a>

Проверка работы методов CRUD в сущности Client (см. [рисунок 6](#figure_6)).  
<a name="figure_6">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643047-2c16bd1d-6c33-421e-998b-ec52e2c5e9ce.png"><br>
        Рисунок 6 - Проверка работы методов CRUD
    </p>
</a>

1. Метод Create позволяет добавлять новые сущности в таблицу (см. [рисунок 7](#figure_7)).
<a name="figure_7">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643142-eb81d4f8-ef8d-4fb6-b75b-4d430e83e6bc.png"><br>
        Рисунок 7 - Метод Create
    </p>
</a>

После успешного выполнения операции сервер выдаёт ответ (см. [рисунок 8](#figure_8)).
<a name="figure_8">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643209-8b688dd1-a30a-4324-b4b1-bbe24ae991e9.png"><br>
        Рисунок 8 - Результат выполнения Create
    </p>
</a>

2. Метод Read позволяет получить сущность из таблицы по его Id (см. [рисунок 9](#figure_9)).
<a name="figure_9">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643285-0305ca75-6eb2-4ca8-b689-f9f75c2b9b14.png"><br>
        Рисунок 9 - Метод Read
    </p>
</a>

После успешного выполнения операции сервер выдаёт ответ (см. [рисунок 10](#figure_10)).
<a name="figure_10">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643319-5c397e57-944f-472f-8b00-051effff73fa.png"><br>
        Рисунок 10 - Результат выполнения Read
    </p>
</a>

3. Метод Update позволяет изменять сущность в таблице (см. [рисунок 11](#figure_11)).
<a name="figure_11">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643557-a4f12342-6487-40f0-b846-94959ce2c772.png"><br>
        Рисунок 11 - Метод Update
    </p>
</a>

После успешного выполнения операции сервер выдаёт ответ (см. [рисунок 12](#figure_12)).
<a name="figure_12">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643563-a2b606e3-5716-4263-aa81-24c841d7b6f9.png"><br>
        Рисунок 12 - Результат выполнения Update
    </p>
</a>

4. Метод Delete позволяет удалить сущность из таблицы по его Id (см. [рисунок 13](#figure_13)).
<a name="figure_13">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643573-439edd15-95a9-4f94-9dd8-fbca07f24123.png"><br>
        Рисунок 13 - Метод Delete
    </p>
</a>

После успешного выполнения операции сервер выдаёт ответ (см. [рисунок 14](#figure_14)).
<a name="figure_14">
    <p align="center">
        <img src="https://user-images.githubusercontent.com/65029862/146643579-fc48eab8-93a5-4ba2-85b7-38dace7cca25.png"><br>
        Рисунок 14 - Результат выполнения Delete
    </p>
</a>

## Заключение <a name="conclusion"></a>

В рамках данной работы была разработана информационная система для приёма заявок на кредит. Для этого сначала были определены внешние системы, влияющие на решение, а также системы, учитываемые при формировании допустимых решений; цели, требования, условия, затем была проведена проверка полноты и достоверности исходных данных, и наконец, были оценены реальные последствия. В перспективе предполагается привязаться проект к базе данных, добавить методы для увеличения спектра возможностей работы на сайте.

## Список использованных источников <a name="bibliography"></a>

<a name="sourse_1"></a>[1] Закон о применении российского ПО [Электронный ресурс] // ФЕДЕРАЛЬНЫЙ ПОРТАЛ ПРОЕКТОВ НОРМАТИВНЫХ ПРАВОВЫХ АКТОВ. Режим доступа: https://regulation.gov.ru/projects#npa=102172, свободный.

<a name="sourse_2"></a>[2] Статья о законе о применении российского ПО [Электронный ресурс] // Владислав Скобелев, Инна Сидоркова, Анастасия Скрынникова - новостной сайт. Режим доступа: https://clck.ru/ZPd7Y, свободный.
<!--https://www.rbc.ru/technology_and_media/20/05/2020/5ec3f99e9a79472ccb6b522d#:~:text=%D0%9C%D0%B8%D0%BD%D0%BA%D0%BE%D0%BC%D1%81%D0%B2%D1%8F%D0%B7%D1%8C%20%D0%BF%D1%80%D0%B5%D0%B4%D0%BB%D0%BE%D0%B6%D0%B8%D0%BB%D0%B0%20%D0%BE%D0%B1%D1%8F%D0%B7%D0%B0%D1%82%D1%8C%20%D0%B2%D0%BB%D0%B0%D0%B4%D0%B5%D0%BB%D1%8C%D1%86%D0%B5%D0%B2%20%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D0%BE%D0%B2%2C%20%D0%B2%D1%85%D0%BE%D0%B4%D1%8F%D1%89%D0%B8%D1%85%20%D0%B2%20%D0%BA%D1%80%D0%B8%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D1%83%D1%8E%20%D0%B8%D0%BD%D1%84%D0%BE%D1%80%D0%BC%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D1%83%D1%8E%20%D0%B8%D0%BD%D1%84%D1%80%D0%B0%D1%81%D1%82%D1%80%D1%83%D0%BA%D1%82%D1%83%D1%80%D1%83%20(%D0%9A%D0%98%D0%98)%2C%20%C2%AB%D0%BF%D1%80%D0%B5%D0%B8%D0%BC%D1%83%D1%89%D0%B5%D1%81%D1%82%D0%B2%D0%B5%D0%BD%D0%BD%D0%BE%20%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D1%82%D1%8C%C2%BB%20%D1%80%D0%BE%D1%81%D1%81%D0%B8%D0%B9%D1%81%D0%BA%D0%B8%D0%B9%20%D1%81%D0%BE%D1%84%D1%82%20%D1%81%201%20%D1%8F%D0%BD%D0%B2%D0%B0%D1%80%D1%8F%202021%20%D0%B3%D0%BE%D0%B4%D0%B0%20%D0%B8%20%D1%80%D0%BE%D1%81%D1%81%D0%B8%D0%B9%D1%81%D0%BA%D0%BE%D0%B5%20%D0%BE%D0%B1%D0%BE%D1%80%D1%83%D0%B4%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5%C2%A0%E2%80%94%20%D1%81%201%20%D1%8F%D0%BD%D0%B2%D0%B0%D1%80%D1%8F%202022%20%D0%B3%D0%BE%D0%B4%D0%B0--->

<a name="sourse_3"></a>[3] Сбербанк // Режим доступа: https://www.sberbank.ru/ru/about/today, свободный.

<a name="sourse_4"></a>[4] ВТб // Режим доступа: https://www.vtb.ru/o-banke/bank-vtb/, свободный.
