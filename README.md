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

<a name="design"></a>

## 3.1 Проектирование

Разработка информационной системы начинается с проектирования диаграммы сценариев использования (Use Case), отражающей действующие лица данной системы (см. [рисунок 1](#figure_1)).
<p align="center"><img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Use%20Case.drawio.svg"></p>
<a name="figure_1"/><p align="center">Рисунок 1 - Диаграмма сценариев использования</p>

На основе Use Case разрабатывается диаграмма потоков данных (Data Flow), которая наглядно отображает течение информации в пределах системы (см. [рисунок 2](#figure_2)).
<p align="center"><img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Data%20Flow.drawio.svg"></p>
<a name="figure_2"/><p align="center">Рисунок 2 - Диаграмма потоков данных</p>

На основе Data Flow разрабатывается диаграмма отношений сущностей (Entity Relationship), на которой показано, как разные сущности взаимодействуют внутри системы (см. [рисунок 3](#figure_3)). К сущностям относятся люди, различные объекты, концепции и т.д.
<p align="center"><img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Entity%20Relationship-Page-1.drawio.svg"></p>
<a name="figure_3"/><p align="center">Рисунок 3 - Диаграмма отношений сущностей</p>

ER-диаграмма (см. [рисунок 3](#figure_3)) отражает отношения между сущностями, но не показывает, каких типов должны быть поля, поэтому была сделана физическая модель данных (см. [рисунок 4](#figure_4)).
<p align="center"><img src="https://raw.githubusercontent.com/sothug/Loan-applications/main/Diagrams/SVG/Entity%20Relationship-Page-2.drawio.svg"></p>
<a name="figure_4"/><p align="center">Рисунок 4 - Физическая модель данных</p>

## 3.2 Реализация <a name="realization"/>

На основе физической модели данных были созданы классы. Ниже приведен пример класса Кредитополучатель (см. [листинг 1](#listing_1)).  
<a name="listing_1"/>Листинг 1 - Класс "Кредитополучатели"
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
Листинг 2 - Интерфейс "IIdentifier" <a name="listing_2"></a>
```csharp
    public interface IIdentifier
    {
        public int Id { get; set; }
    }
```

Поскольку методы CRUD для всех сущностей одинаковы, описывать класс хранилищ для каждой сущности не очень рационально, поэтому было принято решение определить шаблонный класс хранилища (см. [листинг 3](#listing_3)).  
 истинг 3 - Шаблонный класс "Storage" <a name="listing_3"></a>
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

Листинг 4 - Общее хранилище <a name="listing_4"></a>
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

Был разработан набор WEB-методов, включая 4 базисные операции CRUD, для каждой сущности, отражающих предметную область. Примеры контроллеров для классов "Кредитополучатель" и "Вид кредитования".

## 4 Тестирование <a name="testing"></a>

## Заключение <a name="conclusion"></a>

## Список использованных источников <a name="bibliography"></a>

<a name="sourse_1"></a>[1. Закон о применении российского ПО](https://regulation.gov.ru/projects#npa=102172).

<a name="sourse_2"></a>[2. Статья о законе о применении российского ПО](https://www.rbc.ru/technology_and_media/20/05/2020/5ec3f99e9a79472ccb6b522d#:~:text=%D0%9C%D0%B8%D0%BD%D0%BA%D0%BE%D0%BC%D1%81%D0%B2%D1%8F%D0%B7%D1%8C%20%D0%BF%D1%80%D0%B5%D0%B4%D0%BB%D0%BE%D0%B6%D0%B8%D0%BB%D0%B0%20%D0%BE%D0%B1%D1%8F%D0%B7%D0%B0%D1%82%D1%8C%20%D0%B2%D0%BB%D0%B0%D0%B4%D0%B5%D0%BB%D1%8C%D1%86%D0%B5%D0%B2%20%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D0%BE%D0%B2%2C%20%D0%B2%D1%85%D0%BE%D0%B4%D1%8F%D1%89%D0%B8%D1%85%20%D0%B2%20%D0%BA%D1%80%D0%B8%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D1%83%D1%8E%20%D0%B8%D0%BD%D1%84%D0%BE%D1%80%D0%BC%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D1%83%D1%8E%20%D0%B8%D0%BD%D1%84%D1%80%D0%B0%D1%81%D1%82%D1%80%D1%83%D0%BA%D1%82%D1%83%D1%80%D1%83%20(%D0%9A%D0%98%D0%98)%2C%20%C2%AB%D0%BF%D1%80%D0%B5%D0%B8%D0%BC%D1%83%D1%89%D0%B5%D1%81%D1%82%D0%B2%D0%B5%D0%BD%D0%BD%D0%BE%20%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D1%82%D1%8C%C2%BB%20%D1%80%D0%BE%D1%81%D1%81%D0%B8%D0%B9%D1%81%D0%BA%D0%B8%D0%B9%20%D1%81%D0%BE%D1%84%D1%82%20%D1%81%201%20%D1%8F%D0%BD%D0%B2%D0%B0%D1%80%D1%8F%202021%20%D0%B3%D0%BE%D0%B4%D0%B0%20%D0%B8%20%D1%80%D0%BE%D1%81%D1%81%D0%B8%D0%B9%D1%81%D0%BA%D0%BE%D0%B5%20%D0%BE%D0%B1%D0%BE%D1%80%D1%83%D0%B4%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5%C2%A0%E2%80%94%20%D1%81%201%20%D1%8F%D0%BD%D0%B2%D0%B0%D1%80%D1%8F%202022%20%D0%B3%D0%BE%D0%B4%D0%B0).
