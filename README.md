# TestTask

# API


### /api/TextLine - контроллер имеющий следующие методы:

Метод Get вернет данные с 5-ти секундой паузой.

```c#
public ActionResult<IEnumerable<string>> Get()
{
    Thread.Sleep(5000);
    return _service.Data();
}
``` 

###  TextLineService - сервис хранящий метод Data:

Метод Data - возвращает список данных 

```c#
public ActionResult<IEnumerable<string>> Data()
{
    List<string> lines = new List<string>()
    {
        "My name is Linus and I am your God",
        "Microsoft is not evil.",
        "Hello World heheheh"
    };

    return lines;
}
```

Конфигурационный файл с результатом Postman находиться в файле: 

TestAPI.postman_collection
