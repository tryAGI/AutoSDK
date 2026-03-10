//HintName: G.Models.SMBToolConfigParamsDiscriminatorSmbToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SMBToolConfigParamsDiscriminatorSmbToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_rental_availability")]
        CheckRentalAvailability,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_service_availability")]
        CheckServiceAvailability,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_asset")]
        CreateAsset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_client")]
        CreateClient,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_client_appointment")]
        CreateClientAppointment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_product")]
        CreateProduct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_rental_booking")]
        CreateRentalBooking,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_service")]
        CreateService,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_staff")]
        CreateStaff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_asset")]
        DeleteAsset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_calendar_event")]
        DeleteCalendarEvent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_client")]
        DeleteClient,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_product")]
        DeleteProduct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_service")]
        DeleteService,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_staff")]
        DeleteStaff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="get_client_appointments")]
        GetClientAppointments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="get_client_by_phone")]
        GetClientByPhone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_assets")]
        ListAssets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_calendar_events")]
        ListCalendarEvents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_clients")]
        ListClients,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_products")]
        ListProducts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_rental_services")]
        ListRentalServices,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_services")]
        ListServices,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list_staff")]
        ListStaff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_clients")]
        SearchClients,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_asset")]
        UpdateAsset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_calendar_event")]
        UpdateCalendarEvent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_client")]
        UpdateClient,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_product")]
        UpdateProduct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_service")]
        UpdateService,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_staff")]
        UpdateStaff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBToolConfigParamsDiscriminatorSmbToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBToolConfigParamsDiscriminatorSmbToolType value)
        {
            return value switch
            {
                SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability => "check_rental_availability",
                SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability => "check_service_availability",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset => "create_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient => "create_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment => "create_client_appointment",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct => "create_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking => "create_rental_booking",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateService => "create_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff => "create_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset => "delete_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent => "delete_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient => "delete_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct => "delete_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService => "delete_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff => "delete_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments => "get_client_appointments",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone => "get_client_by_phone",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets => "list_assets",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents => "list_calendar_events",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListClients => "list_clients",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts => "list_products",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices => "list_rental_services",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListServices => "list_services",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff => "list_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients => "search_clients",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset => "update_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent => "update_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient => "update_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct => "update_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService => "update_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff => "update_staff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBToolConfigParamsDiscriminatorSmbToolType? ToEnum(string value)
        {
            return value switch
            {
                "check_rental_availability" => SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability,
                "check_service_availability" => SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability,
                "create_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset,
                "create_client" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient,
                "create_client_appointment" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment,
                "create_product" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct,
                "create_rental_booking" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking,
                "create_service" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateService,
                "create_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff,
                "delete_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset,
                "delete_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent,
                "delete_client" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient,
                "delete_product" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct,
                "delete_service" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService,
                "delete_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff,
                "get_client_appointments" => SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments,
                "get_client_by_phone" => SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone,
                "list_assets" => SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets,
                "list_calendar_events" => SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents,
                "list_clients" => SMBToolConfigParamsDiscriminatorSmbToolType.ListClients,
                "list_products" => SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts,
                "list_rental_services" => SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices,
                "list_services" => SMBToolConfigParamsDiscriminatorSmbToolType.ListServices,
                "list_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff,
                "search_clients" => SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients,
                "update_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset,
                "update_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent,
                "update_client" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient,
                "update_product" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct,
                "update_service" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService,
                "update_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff,
                _ => null,
            };
        }
    }
}