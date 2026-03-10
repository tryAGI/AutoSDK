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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SMBToolConfigParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SMBToolConfigParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SMBToolConfigParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SearchClientsParams? searchClients = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchClientsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SearchClientsParams)}");
                searchClients = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListClientsParams? listClients = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListClientsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListClientsParams)}");
                listClients = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetClientByPhoneParams? getClientByPhone = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetClientByPhoneParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetClientByPhoneParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetClientByPhoneParams)}");
                getClientByPhone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateClientParams? createClient = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateClientParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateClientParams)}");
                createClient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateClientParams? updateClient = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateClientParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateClientParams)}");
                updateClient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeleteClientParams? deleteClient = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteClientParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeleteClientParams)}");
                deleteClient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListStaffParams? listStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListStaffParams)}");
                listStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateStaffParams? createStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateStaffParams)}");
                createStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateStaffParams? updateStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateStaffParams)}");
                updateStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeleteStaffParams? deleteStaff = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeleteStaffParams)}");
                deleteStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListAssetsParams? listAssets = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListAssetsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListAssetsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListAssetsParams)}");
                listAssets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAssetParams? createAsset = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssetParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAssetParams)}");
                createAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateAssetParams? updateAsset = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateAssetParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateAssetParams)}");
                updateAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeleteAssetParams? deleteAsset = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteAssetParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeleteAssetParams)}");
                deleteAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListServicesParams? listServices = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListServicesParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListServicesParams)}");
                listServices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateServiceParams? createService = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateServiceParams)}");
                createService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateServiceParams? updateService = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateServiceParams)}");
                updateService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeleteServiceParams? deleteService = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeleteServiceParams)}");
                deleteService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListProductsParams? listProducts = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListProductsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListProductsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListProductsParams)}");
                listProducts = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateProductParams? createProduct = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateProductParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateProductParams)}");
                createProduct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateProductParams? updateProduct = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateProductParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateProductParams)}");
                updateProduct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeleteProductParams? deleteProduct = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteProductParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeleteProductParams)}");
                deleteProduct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CheckServiceAvailabilityParams? checkServiceAvailability = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckServiceAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckServiceAvailabilityParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CheckServiceAvailabilityParams)}");
                checkServiceAvailability = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateClientAppointmentParams? createClientAppointment = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateClientAppointmentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateClientAppointmentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateClientAppointmentParams)}");
                createClientAppointment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetClientAppointmentsParams? getClientAppointments = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetClientAppointmentsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetClientAppointmentsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetClientAppointmentsParams)}");
                getClientAppointments = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListCalendarEventsParams? listCalendarEvents = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListCalendarEventsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListCalendarEventsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListCalendarEventsParams)}");
                listCalendarEvents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateCalendarEventParams? updateCalendarEvent = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateCalendarEventParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateCalendarEventParams)}");
                updateCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeleteCalendarEventParams? deleteCalendarEvent = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteCalendarEventParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeleteCalendarEventParams)}");
                deleteCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListRentalServicesParams? listRentalServices = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListRentalServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListRentalServicesParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListRentalServicesParams)}");
                listRentalServices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CheckRentalAvailabilityParams? checkRentalAvailability = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckRentalAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckRentalAvailabilityParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CheckRentalAvailabilityParams)}");
                checkRentalAvailability = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateRentalBookingParams? createRentalBooking = default;
            if (discriminator?.SmbToolType == global::G.SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRentalBookingParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRentalBookingParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateRentalBookingParams)}");
                createRentalBooking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSearchClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchClientsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SearchClientsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchClients, typeInfo);
            }
            else if (value.IsListClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListClientsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListClientsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListClients, typeInfo);
            }
            else if (value.IsGetClientByPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetClientByPhoneParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetClientByPhoneParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetClientByPhoneParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientByPhone, typeInfo);
            }
            else if (value.IsCreateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateClientParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateClientParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClient, typeInfo);
            }
            else if (value.IsUpdateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateClientParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateClientParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateClient, typeInfo);
            }
            else if (value.IsDeleteClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteClientParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteClientParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteClient, typeInfo);
            }
            else if (value.IsListStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListStaff, typeInfo);
            }
            else if (value.IsCreateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateStaff, typeInfo);
            }
            else if (value.IsUpdateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateStaff, typeInfo);
            }
            else if (value.IsDeleteStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteStaff, typeInfo);
            }
            else if (value.IsListAssets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListAssetsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListAssetsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListAssetsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListAssets, typeInfo);
            }
            else if (value.IsCreateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssetParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAssetParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateAsset, typeInfo);
            }
            else if (value.IsUpdateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateAssetParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateAssetParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateAsset, typeInfo);
            }
            else if (value.IsDeleteAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteAssetParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteAssetParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteAsset, typeInfo);
            }
            else if (value.IsListServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListServicesParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListServicesParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListServices, typeInfo);
            }
            else if (value.IsCreateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateService, typeInfo);
            }
            else if (value.IsUpdateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateService, typeInfo);
            }
            else if (value.IsDeleteService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteService, typeInfo);
            }
            else if (value.IsListProducts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListProductsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListProductsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListProductsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListProducts, typeInfo);
            }
            else if (value.IsCreateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateProductParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateProductParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateProduct, typeInfo);
            }
            else if (value.IsUpdateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateProductParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateProductParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateProduct, typeInfo);
            }
            else if (value.IsDeleteProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteProductParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteProductParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteProduct, typeInfo);
            }
            else if (value.IsCheckServiceAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckServiceAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckServiceAvailabilityParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CheckServiceAvailabilityParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckServiceAvailability, typeInfo);
            }
            else if (value.IsCreateClientAppointment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateClientAppointmentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateClientAppointmentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateClientAppointmentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClientAppointment, typeInfo);
            }
            else if (value.IsGetClientAppointments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetClientAppointmentsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetClientAppointmentsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetClientAppointmentsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientAppointments, typeInfo);
            }
            else if (value.IsListCalendarEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListCalendarEventsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListCalendarEventsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListCalendarEventsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListCalendarEvents, typeInfo);
            }
            else if (value.IsUpdateCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateCalendarEventParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateCalendarEventParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCalendarEvent, typeInfo);
            }
            else if (value.IsDeleteCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteCalendarEventParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteCalendarEventParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteCalendarEvent, typeInfo);
            }
            else if (value.IsListRentalServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListRentalServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListRentalServicesParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListRentalServicesParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListRentalServices, typeInfo);
            }
            else if (value.IsCheckRentalAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CheckRentalAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CheckRentalAvailabilityParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CheckRentalAvailabilityParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckRentalAvailability, typeInfo);
            }
            else if (value.IsCreateRentalBooking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRentalBookingParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRentalBookingParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateRentalBookingParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateRentalBooking, typeInfo);
            }
        }
    }
}