## CloudFoundry WCF Service Hosting Example

This sample assumes you have an existing Windows 2012R2 cell with .NET 4.5.2 registered as the `windows2012R2`
stack in CloudFoundry.

1. `git clone https://github.com/sneal/WCFServiceSample`
2. `cf push wcfsample -s windows2012R2 -b binary_buildpack --health-check-type none -p ./Sneal.Service/Sneal.Service.IIS/`

Take particular note of the handler mapping in the web.config and the associated .svc file in the web project. This
allows the Hostable Web Core to serve the WCF service in the library project.

```
    <handlers>
      <add name="svc-Integrated" path="*.svc" verb="*" type="System.ServiceModel.Activation.HttpHandler, System.ServiceModel.Activation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
    </handlers>
```
