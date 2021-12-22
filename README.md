# .net Core ConsoleApp With .net Core ClassLibrary
This code work shows how can .net Core Class Library connect to a Configuration File/ Azure App Service's Configuration with a .net core Console App both built on .net Framework 5.

## Prerequisites:
1. Visual Studio 2019 or higher
2. .net Core Framework 5
3. An Azure Subscription

> Tested using Azure App Service with `Windows` running `.net 5`

My `appsettings.json` will look like this:

```
{
  "AppSettings": {
    "Org": "Test"
  }
}
```

### How to Access Azure App Service's Configuration > Settings?

`Environment.GetEnvironmentVariable("APPSETTING_Org").ToString();`

### How to Read JSON file's Settings?

`_configuration["AppSettings:Org"];`

> You will need to have `private IConfiguration _configuration;` initialized
