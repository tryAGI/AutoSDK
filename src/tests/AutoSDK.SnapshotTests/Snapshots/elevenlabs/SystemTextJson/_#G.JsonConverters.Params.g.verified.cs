//HintName: G.JsonConverters.Params.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Params>
    {
        /// <inheritdoc />
        public override global::G.Params Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SMBToolConfigParamsDiscriminator>(ref readerCopy, options);

            global::G.SearchClientsParams? searchClients = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients)
            {
                searchClients = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SearchClientsParams>(ref reader, options);
            }
            global::G.ListClientsParams? listClients = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListClients)
            {
                listClients = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListClientsParams>(ref reader, options);
            }
            global::G.GetClientByPhoneParams? getClientByPhone = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone)
            {
                getClientByPhone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetClientByPhoneParams>(ref reader, options);
            }
            global::G.CreateClientParams? createClient = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient)
            {
                createClient = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateClientParams>(ref reader, options);
            }
            global::G.UpdateClientParams? updateClient = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient)
            {
                updateClient = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateClientParams>(ref reader, options);
            }
            global::G.DeleteClientParams? deleteClient = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient)
            {
                deleteClient = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteClientParams>(ref reader, options);
            }
            global::G.ListStaffParams? listStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff)
            {
                listStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListStaffParams>(ref reader, options);
            }
            global::G.CreateStaffParams? createStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff)
            {
                createStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateStaffParams>(ref reader, options);
            }
            global::G.UpdateStaffParams? updateStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff)
            {
                updateStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateStaffParams>(ref reader, options);
            }
            global::G.DeleteStaffParams? deleteStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff)
            {
                deleteStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteStaffParams>(ref reader, options);
            }
            global::G.ListAssetsParams? listAssets = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets)
            {
                listAssets = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListAssetsParams>(ref reader, options);
            }
            global::G.CreateAssetParams? createAsset = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset)
            {
                createAsset = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAssetParams>(ref reader, options);
            }
            global::G.UpdateAssetParams? updateAsset = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset)
            {
                updateAsset = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateAssetParams>(ref reader, options);
            }
            global::G.DeleteAssetParams? deleteAsset = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset)
            {
                deleteAsset = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteAssetParams>(ref reader, options);
            }
            global::G.ListServicesParams? listServices = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListServices)
            {
                listServices = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListServicesParams>(ref reader, options);
            }
            global::G.CreateServiceParams? createService = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateService)
            {
                createService = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateServiceParams>(ref reader, options);
            }
            global::G.UpdateServiceParams? updateService = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService)
            {
                updateService = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateServiceParams>(ref reader, options);
            }
            global::G.DeleteServiceParams? deleteService = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService)
            {
                deleteService = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteServiceParams>(ref reader, options);
            }
            global::G.ListProductsParams? listProducts = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts)
            {
                listProducts = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListProductsParams>(ref reader, options);
            }
            global::G.CreateProductParams? createProduct = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct)
            {
                createProduct = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateProductParams>(ref reader, options);
            }
            global::G.UpdateProductParams? updateProduct = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct)
            {
                updateProduct = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateProductParams>(ref reader, options);
            }
            global::G.DeleteProductParams? deleteProduct = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct)
            {
                deleteProduct = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteProductParams>(ref reader, options);
            }
            global::G.CheckServiceAvailabilityParams? checkServiceAvailability = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability)
            {
                checkServiceAvailability = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckServiceAvailabilityParams>(ref reader, options);
            }
            global::G.CreateClientAppointmentParams? createClientAppointment = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment)
            {
                createClientAppointment = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateClientAppointmentParams>(ref reader, options);
            }
            global::G.GetClientAppointmentsParams? getClientAppointments = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments)
            {
                getClientAppointments = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetClientAppointmentsParams>(ref reader, options);
            }
            global::G.ListCalendarEventsParams? listCalendarEvents = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents)
            {
                listCalendarEvents = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListCalendarEventsParams>(ref reader, options);
            }
            global::G.UpdateCalendarEventParams? updateCalendarEvent = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent)
            {
                updateCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateCalendarEventParams>(ref reader, options);
            }
            global::G.DeleteCalendarEventParams? deleteCalendarEvent = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent)
            {
                deleteCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeleteCalendarEventParams>(ref reader, options);
            }
            global::G.ListRentalServicesParams? listRentalServices = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices)
            {
                listRentalServices = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListRentalServicesParams>(ref reader, options);
            }
            global::G.CheckRentalAvailabilityParams? checkRentalAvailability = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability)
            {
                checkRentalAvailability = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckRentalAvailabilityParams>(ref reader, options);
            }
            global::G.CreateRentalBookingParams? createRentalBooking = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking)
            {
                createRentalBooking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateRentalBookingParams>(ref reader, options);
            }

            var __value = new global::G.Params(
                discriminator?.SmbToolType,
                searchClients,

                listClients,

                getClientByPhone,

                createClient,

                updateClient,

                deleteClient,

                listStaff,

                createStaff,

                updateStaff,

                deleteStaff,

                listAssets,

                createAsset,

                updateAsset,

                deleteAsset,

                listServices,

                createService,

                updateService,

                deleteService,

                listProducts,

                createProduct,

                updateProduct,

                deleteProduct,

                checkServiceAvailability,

                createClientAppointment,

                getClientAppointments,

                listCalendarEvents,

                updateCalendarEvent,

                deleteCalendarEvent,

                listRentalServices,

                checkRentalAvailability,

                createRentalBooking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Params value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSearchClients)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchClients, typeof(global::G.SearchClientsParams), options);
            }
            else if (value.IsListClients)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListClients, typeof(global::G.ListClientsParams), options);
            }
            else if (value.IsGetClientByPhone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientByPhone, typeof(global::G.GetClientByPhoneParams), options);
            }
            else if (value.IsCreateClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClient, typeof(global::G.CreateClientParams), options);
            }
            else if (value.IsUpdateClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateClient, typeof(global::G.UpdateClientParams), options);
            }
            else if (value.IsDeleteClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteClient, typeof(global::G.DeleteClientParams), options);
            }
            else if (value.IsListStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListStaff, typeof(global::G.ListStaffParams), options);
            }
            else if (value.IsCreateStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateStaff, typeof(global::G.CreateStaffParams), options);
            }
            else if (value.IsUpdateStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateStaff, typeof(global::G.UpdateStaffParams), options);
            }
            else if (value.IsDeleteStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteStaff, typeof(global::G.DeleteStaffParams), options);
            }
            else if (value.IsListAssets)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListAssets, typeof(global::G.ListAssetsParams), options);
            }
            else if (value.IsCreateAsset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateAsset, typeof(global::G.CreateAssetParams), options);
            }
            else if (value.IsUpdateAsset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateAsset, typeof(global::G.UpdateAssetParams), options);
            }
            else if (value.IsDeleteAsset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteAsset, typeof(global::G.DeleteAssetParams), options);
            }
            else if (value.IsListServices)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListServices, typeof(global::G.ListServicesParams), options);
            }
            else if (value.IsCreateService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateService, typeof(global::G.CreateServiceParams), options);
            }
            else if (value.IsUpdateService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateService, typeof(global::G.UpdateServiceParams), options);
            }
            else if (value.IsDeleteService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteService, typeof(global::G.DeleteServiceParams), options);
            }
            else if (value.IsListProducts)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListProducts, typeof(global::G.ListProductsParams), options);
            }
            else if (value.IsCreateProduct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateProduct, typeof(global::G.CreateProductParams), options);
            }
            else if (value.IsUpdateProduct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateProduct, typeof(global::G.UpdateProductParams), options);
            }
            else if (value.IsDeleteProduct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteProduct, typeof(global::G.DeleteProductParams), options);
            }
            else if (value.IsCheckServiceAvailability)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckServiceAvailability, typeof(global::G.CheckServiceAvailabilityParams), options);
            }
            else if (value.IsCreateClientAppointment)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClientAppointment, typeof(global::G.CreateClientAppointmentParams), options);
            }
            else if (value.IsGetClientAppointments)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientAppointments, typeof(global::G.GetClientAppointmentsParams), options);
            }
            else if (value.IsListCalendarEvents)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListCalendarEvents, typeof(global::G.ListCalendarEventsParams), options);
            }
            else if (value.IsUpdateCalendarEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCalendarEvent, typeof(global::G.UpdateCalendarEventParams), options);
            }
            else if (value.IsDeleteCalendarEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteCalendarEvent, typeof(global::G.DeleteCalendarEventParams), options);
            }
            else if (value.IsListRentalServices)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListRentalServices, typeof(global::G.ListRentalServicesParams), options);
            }
            else if (value.IsCheckRentalAvailability)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckRentalAvailability, typeof(global::G.CheckRentalAvailabilityParams), options);
            }
            else if (value.IsCreateRentalBooking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateRentalBooking, typeof(global::G.CreateRentalBookingParams), options);
            }
        }
    }
}