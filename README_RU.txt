ILYA CONNECT — исходный проект для Windows 11.

Это исходный код WPF, а не готовый EXE. Для сборки требуется Windows и .NET 8 SDK:
  dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true

Файл появится в:
  bin\Release\net8.0-windows\win-x64\publish\ILYA_CONNECT.exe

Текущая демонстрационная версия открывает официальные веб-версии Telegram и Discord.
Она не подтверждает факт входа, не поддерживает автоматическое создание аккаунтов и не
генерирует номера. Для нескольких аккаунтов используйте отдельные профили браузера
или официальные клиенты, если сервис это поддерживает.
