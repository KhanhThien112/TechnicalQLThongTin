# TechnicalQLThongTin
//sau khi clone về vào phần web.config xóa 
<connectionStrings>
    <add name="TechnicalEntities" connectionString="metadata=res://*/Models.TechnicalEntities.csdl|res://*/Models.TechnicalEntities.ssdl|res://*/Models.TechnicalEntities.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=MAY21;initial catalog=Technical;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>

  tiếp theo Trong mục Models xóa hết chỉ để lại File EmployeeValidation.cs
  Tạo csdl mới trong file script.sql
  Thêm lại CSDL mới
  Models->Add->ADO.NET Entity Data Model -> Đặt tên -> New Connection -> Nhập server name -> Select or enter database -> Tích vào Table và Store Procedures and Functions
