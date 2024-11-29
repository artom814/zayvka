using System;

namespace ClassLibrary1
{
    /// <summary>
    /// создаем класс "Заявка"
    /// </summary>
    public class Application
    {
        /// <summary>
        /// параметр ID "заявка"
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// параметр "оборудование"
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// параметр "серийный номер"
        /// </summary>
        public string SerialNumber { get; private set; }
        /// <summary>
        /// параметр "описание"
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// параметр "ID клиента"
        /// </summary>
        public int ClientID { get; private set; }
        /// <summary>
        /// параметр "приоритетность"
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// параметр "время создания заявки"
        /// </summary>
        public string Create { get; private set; }
        /// <summary>
        /// параметр "время обновления заявки"
        /// </summary>
        public string Update { get; private set; }
        /// <summary>
        /// параметр "статус заявки"
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// параметр "время завершения заявки"
        /// </summary>
        public string Finish { get; private set; }
        /// <summary>
        /// конструктор класса "Заявка"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ClientId"></param>
        public Application(int id, int ClientId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            Description = string.Empty;
            ClientID = ClientId;
            Priority = string.Empty;
            Create = DateTime.MinValue;
            Update = DateTime.Now;
            Finish = DateTime.MaxValue;
            Status = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "Регистрация заявки"
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// параметр ID "заявка" 
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// параметр ID "регистрация"
        /// </summary>
        public int RegistrationID { get; private set;}
        /// <summary>
        /// параметр "Информация"
        /// </summary>
        public string Information { get; private set; }
        /// <summary>
        /// параметр "приоритет"
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// конструктор класса "регистрация"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="registrationId"></param>

        public Registration(int id, int registrationId)
        {
            ID = id;
            RegistrationID = registrationId;
            Information = string.Empty;
            Priority = string.Empty;

        }
    }
    /// <summary>
    /// создаем класс "Обработка"
    /// </summary>
    public class Processing
    {
        /// <summary>
        /// параметр ID "заявка"
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// параметр ID "исполнитель"
        /// </summary>
        public int ExecutorID { get; private set; }
        /// <summary>
        /// параметр "Приоритет"
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// параметр "анализ"
        /// </summary>
        public string Analysis { get; private set; }
        /// <summary>
        /// конструктор класса "обработка"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ExecutorId"></param>

        public Processing(int id, int ExecutorId)
        {
            ID = id;
            ExecutorID = ExecutorId;
            Analysis = string.Empty;
            Priority = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "исполнитель"
    /// </summary>
    public class Execution
    {
        /// <summary>
        /// параметр ID "заявка"
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// параметр ID "исполнитель"
        /// </summary>
        public int ExecutorID { get; private set; }
        /// <summary>
        /// параметр "заказ"
        /// </summary>
        public string Order {  get; private set; }
        /// <summary>
        /// параметр "координация"
        /// </summary>
        public string Coordination { get; private set; }
        /// <summary>
        /// параметр "Ремонт"
        /// </summary>
        public string Repair {  get; private set; }
        /// <summary>
        /// параметр "замена"
        /// </summary>
        public string Replacement { get; private set; }
       /// <summary>
       /// параметр "изменение"
       /// </summary>
        public string Change { get; private set; }
        /// <summary>
        /// конструктор класса "исполнитель"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ExecutorId"></param>

        public Execution(int id, int ExecutorId)
        {
            ID = id;
            ExecutorID = ExecutorId;
            Order = string.Empty;
            Coordination = string.Empty;
            Repair = string.Empty;
            Replacement = string.Empty;
            Change = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "отчет"
    /// </summary>
    public class Report
    {
        /// <summary>
        /// параметр ID "заявка"
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// параметр ID "исполнитель"
        /// </summary>
        public int ExecutorID { get; private set; }
        /// <summary>
        /// параметр "время"
        /// </summary>
        public int Time { get; private set; }
        /// <summary>
        /// параметр "материал"
        /// </summary>
        public string Material { get; private set; }
        /// <summary>
        /// параметр "стоимость"
        /// </summary>
        public int Cost { get; private set; }
        /// <summary>
        /// параметр "причина"
        /// </summary>
        public string Reason { get; private set; }
        /// <summary>
        /// параметр "помощь"
        /// </summary>
        public string Help { get; private set; }
        /// <summary>
        /// конструктор класса "отчет"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ExecutorId"></param>
        /// <param name="time"></param>
        /// <param name="cost"></param>

        public Report(int id, int ExecutorId, int time, int cost)
        {
            ID = id;
            ExecutorID = ExecutorId;
            Time = time;
            Material = string.Empty;
            Cost = cost;
            Reason = string.Empty;
            Help = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "анализ"
    /// </summary>
    public class Analyses
    {
        /// <summary>
        /// параметр ID "заявки"
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// параметр ID "исполнитель"
        /// </summary>
        public int ExecutorID { get; private set; }
        /// <summary>
        /// параметр "время обработки"
        /// </summary>
        public int ProcessingTime { get; private set; }
        /// <summary>
        /// параметр "затраты"
        /// </summary>
        public int Expenditure { get; private set; }
        /// <summary>
        /// параметр "качество"
        /// </summary>
        public string Quality { get; private set; }
        /// <summary>
        /// конструктор класса "Анализ"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ExecutorId"></param>
        /// <param name="Processingtime"></param>
        /// <param name="expenditure"></param>
        public Analyses(int id, int ExecutorId, int Processingtime, int expenditure)
        {
            ID = id;
            ExecutorID = ExecutorId;
            ProcessingTime = Processingtime;
            Expenditure = expenditure;
            Quality = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "клиент"
    /// </summary>
    public class Client
    {
        /// <summary>
        /// параметр "ID клиента"
        /// </summary>
        public int ClientID { get; private set; }
        /// <summary>
        /// параметр "Имя клиента"
        /// </summary>
        public string ClientName { get; private set; }
        /// <summary>
        /// параметр "фамилия клиента"
        /// </summary>
        public string ClientSecondName {  get; private set; }
        /// <summary>
        /// параметр "отчество клиента"
        /// </summary>
        public string ClientFatherName { get; private set; }
        /// <summary>
        /// параметр "дата рождения"
        /// </summary>
        public string Birthday {  get; private set; }
        /// <summary>
        /// параметр "номер клиента"
        /// </summary>
        public string ClientNumber { get; private set; }
        /// <summary>
        /// параметр "электронная почта клиента"
        /// </summary>
        public string ClientEmail { get; private set; }
        /// <summary>
        /// конструктор класса "клиент"
        /// </summary>
        /// <param name="clientId"></param>

        public Client(int clientId)
        {
            ClientID = clientId;
            ClientName = string.Empty;
            ClientSecondName = string.Empty;
            ClientFatherName = string.Empty;
            Birthday = string.Empty;
            ClientNumber = string.Empty;
            ClientEmail = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "исполнитель"
    /// </summary>
    public class Executor
    {
        /// <summary>
        /// параметр "ID исполнителя"
        /// </summary>
        public int ExecutorID { get; private set; }
        /// <summary>
        /// параметр "имя исполнителя"
        /// </summary>
        public string ExecutorName { get; private set; }
        /// <summary>
        /// параметр "фамилия исполнителя"
        /// </summary>
        public string ExecutorSecondName { get; private set; }
        /// <summary>
        /// параметр "отчество исполнителя"
        /// </summary>
        public string ExecutorFatherName { get; private set; }
        /// <summary>
        /// параметр "номер клиента"
        /// </summary>
        public string ExecutorNumber { get; private set; }
        /// <summary>
        /// параметр "почта клиента"
        /// </summary>
        public string ExecutorEmail { get; private set; }
        /// <summary>
        /// параметр "квалификация"
        /// </summary>
        public string Qualification { get; private set; }
        /// <summary>
        /// конструктор класса "исполнитель"
        /// </summary>
        /// <param name="ExecutorId"></param>

        public Executor(int ExecutorId)
        {
            ExecutorID = ExecutorId;
            ExecutorName = string.Empty;
            ExecutorSecondName = string.Empty;
            ExecutorFatherName = string.Empty;
            ExecutorNumber = string.Empty;
            ExecutorEmail = string.Empty;
            Qualification = string.Empty;
        }
    }
    /// <summary>
    /// создаем класс "программа"
    /// </summary>
    public class Program
    {

    }
}