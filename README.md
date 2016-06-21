## CloudFoundry WCF Service Hosting Example

Take particular note of the handler mapping in the web.config

```
    <handlers>
      <add name="svc-Integrated" path="*.svc" verb="*" type="System.ServiceModel.Activation.HttpHandler, System.ServiceModel.Activation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
    </handlers>
```
