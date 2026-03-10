//HintName: G.Models.Params.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params : global::System.IEquatable<Params>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SMBToolConfigParamsDiscriminatorSmbToolType? SmbToolType { get; }

        /// <summary>
        /// Search for clients by name, phone number, or email.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchClientsParams? SearchClients { get; init; }
#else
        public global::G.SearchClientsParams? SearchClients { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchClients))]
#endif
        public bool IsSearchClients => SearchClients != null;

        /// <summary>
        /// List clients ordered by most recently updated, with an optional limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListClientsParams? ListClients { get; init; }
#else
        public global::G.ListClientsParams? ListClients { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListClients))]
#endif
        public bool IsListClients => ListClients != null;

        /// <summary>
        /// Look up a client by their exact phone number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetClientByPhoneParams? GetClientByPhone { get; init; }
#else
        public global::G.GetClientByPhoneParams? GetClientByPhone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetClientByPhone))]
#endif
        public bool IsGetClientByPhone => GetClientByPhone != null;

        /// <summary>
        /// Create a new client in the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateClientParams? CreateClient { get; init; }
#else
        public global::G.CreateClientParams? CreateClient { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateClient))]
#endif
        public bool IsCreateClient => CreateClient != null;

        /// <summary>
        /// Update an existing client's information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateClientParams? UpdateClient { get; init; }
#else
        public global::G.UpdateClientParams? UpdateClient { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateClient))]
#endif
        public bool IsUpdateClient => UpdateClient != null;

        /// <summary>
        /// Delete an existing client from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteClientParams? DeleteClient { get; init; }
#else
        public global::G.DeleteClientParams? DeleteClient { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteClient))]
#endif
        public bool IsDeleteClient => DeleteClient != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListStaffParams? ListStaff { get; init; }
#else
        public global::G.ListStaffParams? ListStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListStaff))]
#endif
        public bool IsListStaff => ListStaff != null;

        /// <summary>
        /// Create a new staff member in the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateStaffParams? CreateStaff { get; init; }
#else
        public global::G.CreateStaffParams? CreateStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateStaff))]
#endif
        public bool IsCreateStaff => CreateStaff != null;

        /// <summary>
        /// Update an existing staff member's information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateStaffParams? UpdateStaff { get; init; }
#else
        public global::G.UpdateStaffParams? UpdateStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateStaff))]
#endif
        public bool IsUpdateStaff => UpdateStaff != null;

        /// <summary>
        /// Delete an existing staff member from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteStaffParams? DeleteStaff { get; init; }
#else
        public global::G.DeleteStaffParams? DeleteStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteStaff))]
#endif
        public bool IsDeleteStaff => DeleteStaff != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListAssetsParams? ListAssets { get; init; }
#else
        public global::G.ListAssetsParams? ListAssets { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListAssets))]
#endif
        public bool IsListAssets => ListAssets != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAssetParams? CreateAsset { get; init; }
#else
        public global::G.CreateAssetParams? CreateAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateAsset))]
#endif
        public bool IsCreateAsset => CreateAsset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateAssetParams? UpdateAsset { get; init; }
#else
        public global::G.UpdateAssetParams? UpdateAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateAsset))]
#endif
        public bool IsUpdateAsset => UpdateAsset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteAssetParams? DeleteAsset { get; init; }
#else
        public global::G.DeleteAssetParams? DeleteAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteAsset))]
#endif
        public bool IsDeleteAsset => DeleteAsset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListServicesParams? ListServices { get; init; }
#else
        public global::G.ListServicesParams? ListServices { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListServices))]
#endif
        public bool IsListServices => ListServices != null;

        /// <summary>
        /// Create a new service in the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateServiceParams? CreateService { get; init; }
#else
        public global::G.CreateServiceParams? CreateService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateService))]
#endif
        public bool IsCreateService => CreateService != null;

        /// <summary>
        /// Update an existing service's information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateServiceParams? UpdateService { get; init; }
#else
        public global::G.UpdateServiceParams? UpdateService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateService))]
#endif
        public bool IsUpdateService => UpdateService != null;

        /// <summary>
        /// Delete an existing service from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteServiceParams? DeleteService { get; init; }
#else
        public global::G.DeleteServiceParams? DeleteService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteService))]
#endif
        public bool IsDeleteService => DeleteService != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListProductsParams? ListProducts { get; init; }
#else
        public global::G.ListProductsParams? ListProducts { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListProducts))]
#endif
        public bool IsListProducts => ListProducts != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateProductParams? CreateProduct { get; init; }
#else
        public global::G.CreateProductParams? CreateProduct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateProduct))]
#endif
        public bool IsCreateProduct => CreateProduct != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateProductParams? UpdateProduct { get; init; }
#else
        public global::G.UpdateProductParams? UpdateProduct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateProduct))]
#endif
        public bool IsUpdateProduct => UpdateProduct != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteProductParams? DeleteProduct { get; init; }
#else
        public global::G.DeleteProductParams? DeleteProduct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteProduct))]
#endif
        public bool IsDeleteProduct => DeleteProduct != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CheckServiceAvailabilityParams? CheckServiceAvailability { get; init; }
#else
        public global::G.CheckServiceAvailabilityParams? CheckServiceAvailability { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CheckServiceAvailability))]
#endif
        public bool IsCheckServiceAvailability => CheckServiceAvailability != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateClientAppointmentParams? CreateClientAppointment { get; init; }
#else
        public global::G.CreateClientAppointmentParams? CreateClientAppointment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateClientAppointment))]
#endif
        public bool IsCreateClientAppointment => CreateClientAppointment != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetClientAppointmentsParams? GetClientAppointments { get; init; }
#else
        public global::G.GetClientAppointmentsParams? GetClientAppointments { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetClientAppointments))]
#endif
        public bool IsGetClientAppointments => GetClientAppointments != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListCalendarEventsParams? ListCalendarEvents { get; init; }
#else
        public global::G.ListCalendarEventsParams? ListCalendarEvents { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListCalendarEvents))]
#endif
        public bool IsListCalendarEvents => ListCalendarEvents != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateCalendarEventParams? UpdateCalendarEvent { get; init; }
#else
        public global::G.UpdateCalendarEventParams? UpdateCalendarEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCalendarEvent))]
#endif
        public bool IsUpdateCalendarEvent => UpdateCalendarEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteCalendarEventParams? DeleteCalendarEvent { get; init; }
#else
        public global::G.DeleteCalendarEventParams? DeleteCalendarEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteCalendarEvent))]
#endif
        public bool IsDeleteCalendarEvent => DeleteCalendarEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListRentalServicesParams? ListRentalServices { get; init; }
#else
        public global::G.ListRentalServicesParams? ListRentalServices { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListRentalServices))]
#endif
        public bool IsListRentalServices => ListRentalServices != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CheckRentalAvailabilityParams? CheckRentalAvailability { get; init; }
#else
        public global::G.CheckRentalAvailabilityParams? CheckRentalAvailability { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CheckRentalAvailability))]
#endif
        public bool IsCheckRentalAvailability => CheckRentalAvailability != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateRentalBookingParams? CreateRentalBooking { get; init; }
#else
        public global::G.CreateRentalBookingParams? CreateRentalBooking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateRentalBooking))]
#endif
        public bool IsCreateRentalBooking => CreateRentalBooking != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.SearchClientsParams value) => new Params((global::G.SearchClientsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchClientsParams?(Params @this) => @this.SearchClients;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.SearchClientsParams? value)
        {
            SearchClients = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListClientsParams value) => new Params((global::G.ListClientsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListClientsParams?(Params @this) => @this.ListClients;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListClientsParams? value)
        {
            ListClients = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.GetClientByPhoneParams value) => new Params((global::G.GetClientByPhoneParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetClientByPhoneParams?(Params @this) => @this.GetClientByPhone;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.GetClientByPhoneParams? value)
        {
            GetClientByPhone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateClientParams value) => new Params((global::G.CreateClientParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateClientParams?(Params @this) => @this.CreateClient;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateClientParams? value)
        {
            CreateClient = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.UpdateClientParams value) => new Params((global::G.UpdateClientParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateClientParams?(Params @this) => @this.UpdateClient;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.UpdateClientParams? value)
        {
            UpdateClient = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.DeleteClientParams value) => new Params((global::G.DeleteClientParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteClientParams?(Params @this) => @this.DeleteClient;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.DeleteClientParams? value)
        {
            DeleteClient = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListStaffParams value) => new Params((global::G.ListStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListStaffParams?(Params @this) => @this.ListStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListStaffParams? value)
        {
            ListStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateStaffParams value) => new Params((global::G.CreateStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateStaffParams?(Params @this) => @this.CreateStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateStaffParams? value)
        {
            CreateStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.UpdateStaffParams value) => new Params((global::G.UpdateStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateStaffParams?(Params @this) => @this.UpdateStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.UpdateStaffParams? value)
        {
            UpdateStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.DeleteStaffParams value) => new Params((global::G.DeleteStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteStaffParams?(Params @this) => @this.DeleteStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.DeleteStaffParams? value)
        {
            DeleteStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListAssetsParams value) => new Params((global::G.ListAssetsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListAssetsParams?(Params @this) => @this.ListAssets;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListAssetsParams? value)
        {
            ListAssets = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateAssetParams value) => new Params((global::G.CreateAssetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAssetParams?(Params @this) => @this.CreateAsset;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateAssetParams? value)
        {
            CreateAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.UpdateAssetParams value) => new Params((global::G.UpdateAssetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateAssetParams?(Params @this) => @this.UpdateAsset;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.UpdateAssetParams? value)
        {
            UpdateAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.DeleteAssetParams value) => new Params((global::G.DeleteAssetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteAssetParams?(Params @this) => @this.DeleteAsset;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.DeleteAssetParams? value)
        {
            DeleteAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListServicesParams value) => new Params((global::G.ListServicesParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListServicesParams?(Params @this) => @this.ListServices;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListServicesParams? value)
        {
            ListServices = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateServiceParams value) => new Params((global::G.CreateServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateServiceParams?(Params @this) => @this.CreateService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateServiceParams? value)
        {
            CreateService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.UpdateServiceParams value) => new Params((global::G.UpdateServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateServiceParams?(Params @this) => @this.UpdateService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.UpdateServiceParams? value)
        {
            UpdateService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.DeleteServiceParams value) => new Params((global::G.DeleteServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteServiceParams?(Params @this) => @this.DeleteService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.DeleteServiceParams? value)
        {
            DeleteService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListProductsParams value) => new Params((global::G.ListProductsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListProductsParams?(Params @this) => @this.ListProducts;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListProductsParams? value)
        {
            ListProducts = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateProductParams value) => new Params((global::G.CreateProductParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateProductParams?(Params @this) => @this.CreateProduct;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateProductParams? value)
        {
            CreateProduct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.UpdateProductParams value) => new Params((global::G.UpdateProductParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateProductParams?(Params @this) => @this.UpdateProduct;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.UpdateProductParams? value)
        {
            UpdateProduct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.DeleteProductParams value) => new Params((global::G.DeleteProductParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteProductParams?(Params @this) => @this.DeleteProduct;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.DeleteProductParams? value)
        {
            DeleteProduct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CheckServiceAvailabilityParams value) => new Params((global::G.CheckServiceAvailabilityParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CheckServiceAvailabilityParams?(Params @this) => @this.CheckServiceAvailability;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CheckServiceAvailabilityParams? value)
        {
            CheckServiceAvailability = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateClientAppointmentParams value) => new Params((global::G.CreateClientAppointmentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateClientAppointmentParams?(Params @this) => @this.CreateClientAppointment;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateClientAppointmentParams? value)
        {
            CreateClientAppointment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.GetClientAppointmentsParams value) => new Params((global::G.GetClientAppointmentsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetClientAppointmentsParams?(Params @this) => @this.GetClientAppointments;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.GetClientAppointmentsParams? value)
        {
            GetClientAppointments = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListCalendarEventsParams value) => new Params((global::G.ListCalendarEventsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListCalendarEventsParams?(Params @this) => @this.ListCalendarEvents;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListCalendarEventsParams? value)
        {
            ListCalendarEvents = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.UpdateCalendarEventParams value) => new Params((global::G.UpdateCalendarEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateCalendarEventParams?(Params @this) => @this.UpdateCalendarEvent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.UpdateCalendarEventParams? value)
        {
            UpdateCalendarEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.DeleteCalendarEventParams value) => new Params((global::G.DeleteCalendarEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteCalendarEventParams?(Params @this) => @this.DeleteCalendarEvent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.DeleteCalendarEventParams? value)
        {
            DeleteCalendarEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.ListRentalServicesParams value) => new Params((global::G.ListRentalServicesParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListRentalServicesParams?(Params @this) => @this.ListRentalServices;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.ListRentalServicesParams? value)
        {
            ListRentalServices = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CheckRentalAvailabilityParams value) => new Params((global::G.CheckRentalAvailabilityParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CheckRentalAvailabilityParams?(Params @this) => @this.CheckRentalAvailability;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CheckRentalAvailabilityParams? value)
        {
            CheckRentalAvailability = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.CreateRentalBookingParams value) => new Params((global::G.CreateRentalBookingParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateRentalBookingParams?(Params @this) => @this.CreateRentalBooking;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.CreateRentalBookingParams? value)
        {
            CreateRentalBooking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params(
            global::G.SMBToolConfigParamsDiscriminatorSmbToolType? smbToolType,
            global::G.SearchClientsParams? searchClients,
            global::G.ListClientsParams? listClients,
            global::G.GetClientByPhoneParams? getClientByPhone,
            global::G.CreateClientParams? createClient,
            global::G.UpdateClientParams? updateClient,
            global::G.DeleteClientParams? deleteClient,
            global::G.ListStaffParams? listStaff,
            global::G.CreateStaffParams? createStaff,
            global::G.UpdateStaffParams? updateStaff,
            global::G.DeleteStaffParams? deleteStaff,
            global::G.ListAssetsParams? listAssets,
            global::G.CreateAssetParams? createAsset,
            global::G.UpdateAssetParams? updateAsset,
            global::G.DeleteAssetParams? deleteAsset,
            global::G.ListServicesParams? listServices,
            global::G.CreateServiceParams? createService,
            global::G.UpdateServiceParams? updateService,
            global::G.DeleteServiceParams? deleteService,
            global::G.ListProductsParams? listProducts,
            global::G.CreateProductParams? createProduct,
            global::G.UpdateProductParams? updateProduct,
            global::G.DeleteProductParams? deleteProduct,
            global::G.CheckServiceAvailabilityParams? checkServiceAvailability,
            global::G.CreateClientAppointmentParams? createClientAppointment,
            global::G.GetClientAppointmentsParams? getClientAppointments,
            global::G.ListCalendarEventsParams? listCalendarEvents,
            global::G.UpdateCalendarEventParams? updateCalendarEvent,
            global::G.DeleteCalendarEventParams? deleteCalendarEvent,
            global::G.ListRentalServicesParams? listRentalServices,
            global::G.CheckRentalAvailabilityParams? checkRentalAvailability,
            global::G.CreateRentalBookingParams? createRentalBooking
            )
        {
            SmbToolType = smbToolType;

            SearchClients = searchClients;
            ListClients = listClients;
            GetClientByPhone = getClientByPhone;
            CreateClient = createClient;
            UpdateClient = updateClient;
            DeleteClient = deleteClient;
            ListStaff = listStaff;
            CreateStaff = createStaff;
            UpdateStaff = updateStaff;
            DeleteStaff = deleteStaff;
            ListAssets = listAssets;
            CreateAsset = createAsset;
            UpdateAsset = updateAsset;
            DeleteAsset = deleteAsset;
            ListServices = listServices;
            CreateService = createService;
            UpdateService = updateService;
            DeleteService = deleteService;
            ListProducts = listProducts;
            CreateProduct = createProduct;
            UpdateProduct = updateProduct;
            DeleteProduct = deleteProduct;
            CheckServiceAvailability = checkServiceAvailability;
            CreateClientAppointment = createClientAppointment;
            GetClientAppointments = getClientAppointments;
            ListCalendarEvents = listCalendarEvents;
            UpdateCalendarEvent = updateCalendarEvent;
            DeleteCalendarEvent = deleteCalendarEvent;
            ListRentalServices = listRentalServices;
            CheckRentalAvailability = checkRentalAvailability;
            CreateRentalBooking = createRentalBooking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateRentalBooking as object ??
            CheckRentalAvailability as object ??
            ListRentalServices as object ??
            DeleteCalendarEvent as object ??
            UpdateCalendarEvent as object ??
            ListCalendarEvents as object ??
            GetClientAppointments as object ??
            CreateClientAppointment as object ??
            CheckServiceAvailability as object ??
            DeleteProduct as object ??
            UpdateProduct as object ??
            CreateProduct as object ??
            ListProducts as object ??
            DeleteService as object ??
            UpdateService as object ??
            CreateService as object ??
            ListServices as object ??
            DeleteAsset as object ??
            UpdateAsset as object ??
            CreateAsset as object ??
            ListAssets as object ??
            DeleteStaff as object ??
            UpdateStaff as object ??
            CreateStaff as object ??
            ListStaff as object ??
            DeleteClient as object ??
            UpdateClient as object ??
            CreateClient as object ??
            GetClientByPhone as object ??
            ListClients as object ??
            SearchClients as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchClients?.ToString() ??
            ListClients?.ToString() ??
            GetClientByPhone?.ToString() ??
            CreateClient?.ToString() ??
            UpdateClient?.ToString() ??
            DeleteClient?.ToString() ??
            ListStaff?.ToString() ??
            CreateStaff?.ToString() ??
            UpdateStaff?.ToString() ??
            DeleteStaff?.ToString() ??
            ListAssets?.ToString() ??
            CreateAsset?.ToString() ??
            UpdateAsset?.ToString() ??
            DeleteAsset?.ToString() ??
            ListServices?.ToString() ??
            CreateService?.ToString() ??
            UpdateService?.ToString() ??
            DeleteService?.ToString() ??
            ListProducts?.ToString() ??
            CreateProduct?.ToString() ??
            UpdateProduct?.ToString() ??
            DeleteProduct?.ToString() ??
            CheckServiceAvailability?.ToString() ??
            CreateClientAppointment?.ToString() ??
            GetClientAppointments?.ToString() ??
            ListCalendarEvents?.ToString() ??
            UpdateCalendarEvent?.ToString() ??
            DeleteCalendarEvent?.ToString() ??
            ListRentalServices?.ToString() ??
            CheckRentalAvailability?.ToString() ??
            CreateRentalBooking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && IsCreateRentalBooking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SearchClientsParams?, TResult>? searchClients = null,
            global::System.Func<global::G.ListClientsParams?, TResult>? listClients = null,
            global::System.Func<global::G.GetClientByPhoneParams?, TResult>? getClientByPhone = null,
            global::System.Func<global::G.CreateClientParams?, TResult>? createClient = null,
            global::System.Func<global::G.UpdateClientParams?, TResult>? updateClient = null,
            global::System.Func<global::G.DeleteClientParams?, TResult>? deleteClient = null,
            global::System.Func<global::G.ListStaffParams?, TResult>? listStaff = null,
            global::System.Func<global::G.CreateStaffParams?, TResult>? createStaff = null,
            global::System.Func<global::G.UpdateStaffParams?, TResult>? updateStaff = null,
            global::System.Func<global::G.DeleteStaffParams?, TResult>? deleteStaff = null,
            global::System.Func<global::G.ListAssetsParams?, TResult>? listAssets = null,
            global::System.Func<global::G.CreateAssetParams?, TResult>? createAsset = null,
            global::System.Func<global::G.UpdateAssetParams?, TResult>? updateAsset = null,
            global::System.Func<global::G.DeleteAssetParams?, TResult>? deleteAsset = null,
            global::System.Func<global::G.ListServicesParams?, TResult>? listServices = null,
            global::System.Func<global::G.CreateServiceParams?, TResult>? createService = null,
            global::System.Func<global::G.UpdateServiceParams?, TResult>? updateService = null,
            global::System.Func<global::G.DeleteServiceParams?, TResult>? deleteService = null,
            global::System.Func<global::G.ListProductsParams?, TResult>? listProducts = null,
            global::System.Func<global::G.CreateProductParams?, TResult>? createProduct = null,
            global::System.Func<global::G.UpdateProductParams?, TResult>? updateProduct = null,
            global::System.Func<global::G.DeleteProductParams?, TResult>? deleteProduct = null,
            global::System.Func<global::G.CheckServiceAvailabilityParams?, TResult>? checkServiceAvailability = null,
            global::System.Func<global::G.CreateClientAppointmentParams?, TResult>? createClientAppointment = null,
            global::System.Func<global::G.GetClientAppointmentsParams?, TResult>? getClientAppointments = null,
            global::System.Func<global::G.ListCalendarEventsParams?, TResult>? listCalendarEvents = null,
            global::System.Func<global::G.UpdateCalendarEventParams?, TResult>? updateCalendarEvent = null,
            global::System.Func<global::G.DeleteCalendarEventParams?, TResult>? deleteCalendarEvent = null,
            global::System.Func<global::G.ListRentalServicesParams?, TResult>? listRentalServices = null,
            global::System.Func<global::G.CheckRentalAvailabilityParams?, TResult>? checkRentalAvailability = null,
            global::System.Func<global::G.CreateRentalBookingParams?, TResult>? createRentalBooking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchClients && searchClients != null)
            {
                return searchClients(SearchClients!);
            }
            else if (IsListClients && listClients != null)
            {
                return listClients(ListClients!);
            }
            else if (IsGetClientByPhone && getClientByPhone != null)
            {
                return getClientByPhone(GetClientByPhone!);
            }
            else if (IsCreateClient && createClient != null)
            {
                return createClient(CreateClient!);
            }
            else if (IsUpdateClient && updateClient != null)
            {
                return updateClient(UpdateClient!);
            }
            else if (IsDeleteClient && deleteClient != null)
            {
                return deleteClient(DeleteClient!);
            }
            else if (IsListStaff && listStaff != null)
            {
                return listStaff(ListStaff!);
            }
            else if (IsCreateStaff && createStaff != null)
            {
                return createStaff(CreateStaff!);
            }
            else if (IsUpdateStaff && updateStaff != null)
            {
                return updateStaff(UpdateStaff!);
            }
            else if (IsDeleteStaff && deleteStaff != null)
            {
                return deleteStaff(DeleteStaff!);
            }
            else if (IsListAssets && listAssets != null)
            {
                return listAssets(ListAssets!);
            }
            else if (IsCreateAsset && createAsset != null)
            {
                return createAsset(CreateAsset!);
            }
            else if (IsUpdateAsset && updateAsset != null)
            {
                return updateAsset(UpdateAsset!);
            }
            else if (IsDeleteAsset && deleteAsset != null)
            {
                return deleteAsset(DeleteAsset!);
            }
            else if (IsListServices && listServices != null)
            {
                return listServices(ListServices!);
            }
            else if (IsCreateService && createService != null)
            {
                return createService(CreateService!);
            }
            else if (IsUpdateService && updateService != null)
            {
                return updateService(UpdateService!);
            }
            else if (IsDeleteService && deleteService != null)
            {
                return deleteService(DeleteService!);
            }
            else if (IsListProducts && listProducts != null)
            {
                return listProducts(ListProducts!);
            }
            else if (IsCreateProduct && createProduct != null)
            {
                return createProduct(CreateProduct!);
            }
            else if (IsUpdateProduct && updateProduct != null)
            {
                return updateProduct(UpdateProduct!);
            }
            else if (IsDeleteProduct && deleteProduct != null)
            {
                return deleteProduct(DeleteProduct!);
            }
            else if (IsCheckServiceAvailability && checkServiceAvailability != null)
            {
                return checkServiceAvailability(CheckServiceAvailability!);
            }
            else if (IsCreateClientAppointment && createClientAppointment != null)
            {
                return createClientAppointment(CreateClientAppointment!);
            }
            else if (IsGetClientAppointments && getClientAppointments != null)
            {
                return getClientAppointments(GetClientAppointments!);
            }
            else if (IsListCalendarEvents && listCalendarEvents != null)
            {
                return listCalendarEvents(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent && updateCalendarEvent != null)
            {
                return updateCalendarEvent(UpdateCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent && deleteCalendarEvent != null)
            {
                return deleteCalendarEvent(DeleteCalendarEvent!);
            }
            else if (IsListRentalServices && listRentalServices != null)
            {
                return listRentalServices(ListRentalServices!);
            }
            else if (IsCheckRentalAvailability && checkRentalAvailability != null)
            {
                return checkRentalAvailability(CheckRentalAvailability!);
            }
            else if (IsCreateRentalBooking && createRentalBooking != null)
            {
                return createRentalBooking(CreateRentalBooking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SearchClientsParams?>? searchClients = null,
            global::System.Action<global::G.ListClientsParams?>? listClients = null,
            global::System.Action<global::G.GetClientByPhoneParams?>? getClientByPhone = null,
            global::System.Action<global::G.CreateClientParams?>? createClient = null,
            global::System.Action<global::G.UpdateClientParams?>? updateClient = null,
            global::System.Action<global::G.DeleteClientParams?>? deleteClient = null,
            global::System.Action<global::G.ListStaffParams?>? listStaff = null,
            global::System.Action<global::G.CreateStaffParams?>? createStaff = null,
            global::System.Action<global::G.UpdateStaffParams?>? updateStaff = null,
            global::System.Action<global::G.DeleteStaffParams?>? deleteStaff = null,
            global::System.Action<global::G.ListAssetsParams?>? listAssets = null,
            global::System.Action<global::G.CreateAssetParams?>? createAsset = null,
            global::System.Action<global::G.UpdateAssetParams?>? updateAsset = null,
            global::System.Action<global::G.DeleteAssetParams?>? deleteAsset = null,
            global::System.Action<global::G.ListServicesParams?>? listServices = null,
            global::System.Action<global::G.CreateServiceParams?>? createService = null,
            global::System.Action<global::G.UpdateServiceParams?>? updateService = null,
            global::System.Action<global::G.DeleteServiceParams?>? deleteService = null,
            global::System.Action<global::G.ListProductsParams?>? listProducts = null,
            global::System.Action<global::G.CreateProductParams?>? createProduct = null,
            global::System.Action<global::G.UpdateProductParams?>? updateProduct = null,
            global::System.Action<global::G.DeleteProductParams?>? deleteProduct = null,
            global::System.Action<global::G.CheckServiceAvailabilityParams?>? checkServiceAvailability = null,
            global::System.Action<global::G.CreateClientAppointmentParams?>? createClientAppointment = null,
            global::System.Action<global::G.GetClientAppointmentsParams?>? getClientAppointments = null,
            global::System.Action<global::G.ListCalendarEventsParams?>? listCalendarEvents = null,
            global::System.Action<global::G.UpdateCalendarEventParams?>? updateCalendarEvent = null,
            global::System.Action<global::G.DeleteCalendarEventParams?>? deleteCalendarEvent = null,
            global::System.Action<global::G.ListRentalServicesParams?>? listRentalServices = null,
            global::System.Action<global::G.CheckRentalAvailabilityParams?>? checkRentalAvailability = null,
            global::System.Action<global::G.CreateRentalBookingParams?>? createRentalBooking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchClients)
            {
                searchClients?.Invoke(SearchClients!);
            }
            else if (IsListClients)
            {
                listClients?.Invoke(ListClients!);
            }
            else if (IsGetClientByPhone)
            {
                getClientByPhone?.Invoke(GetClientByPhone!);
            }
            else if (IsCreateClient)
            {
                createClient?.Invoke(CreateClient!);
            }
            else if (IsUpdateClient)
            {
                updateClient?.Invoke(UpdateClient!);
            }
            else if (IsDeleteClient)
            {
                deleteClient?.Invoke(DeleteClient!);
            }
            else if (IsListStaff)
            {
                listStaff?.Invoke(ListStaff!);
            }
            else if (IsCreateStaff)
            {
                createStaff?.Invoke(CreateStaff!);
            }
            else if (IsUpdateStaff)
            {
                updateStaff?.Invoke(UpdateStaff!);
            }
            else if (IsDeleteStaff)
            {
                deleteStaff?.Invoke(DeleteStaff!);
            }
            else if (IsListAssets)
            {
                listAssets?.Invoke(ListAssets!);
            }
            else if (IsCreateAsset)
            {
                createAsset?.Invoke(CreateAsset!);
            }
            else if (IsUpdateAsset)
            {
                updateAsset?.Invoke(UpdateAsset!);
            }
            else if (IsDeleteAsset)
            {
                deleteAsset?.Invoke(DeleteAsset!);
            }
            else if (IsListServices)
            {
                listServices?.Invoke(ListServices!);
            }
            else if (IsCreateService)
            {
                createService?.Invoke(CreateService!);
            }
            else if (IsUpdateService)
            {
                updateService?.Invoke(UpdateService!);
            }
            else if (IsDeleteService)
            {
                deleteService?.Invoke(DeleteService!);
            }
            else if (IsListProducts)
            {
                listProducts?.Invoke(ListProducts!);
            }
            else if (IsCreateProduct)
            {
                createProduct?.Invoke(CreateProduct!);
            }
            else if (IsUpdateProduct)
            {
                updateProduct?.Invoke(UpdateProduct!);
            }
            else if (IsDeleteProduct)
            {
                deleteProduct?.Invoke(DeleteProduct!);
            }
            else if (IsCheckServiceAvailability)
            {
                checkServiceAvailability?.Invoke(CheckServiceAvailability!);
            }
            else if (IsCreateClientAppointment)
            {
                createClientAppointment?.Invoke(CreateClientAppointment!);
            }
            else if (IsGetClientAppointments)
            {
                getClientAppointments?.Invoke(GetClientAppointments!);
            }
            else if (IsListCalendarEvents)
            {
                listCalendarEvents?.Invoke(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent)
            {
                updateCalendarEvent?.Invoke(UpdateCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent)
            {
                deleteCalendarEvent?.Invoke(DeleteCalendarEvent!);
            }
            else if (IsListRentalServices)
            {
                listRentalServices?.Invoke(ListRentalServices!);
            }
            else if (IsCheckRentalAvailability)
            {
                checkRentalAvailability?.Invoke(CheckRentalAvailability!);
            }
            else if (IsCreateRentalBooking)
            {
                createRentalBooking?.Invoke(CreateRentalBooking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchClients,
                typeof(global::G.SearchClientsParams),
                ListClients,
                typeof(global::G.ListClientsParams),
                GetClientByPhone,
                typeof(global::G.GetClientByPhoneParams),
                CreateClient,
                typeof(global::G.CreateClientParams),
                UpdateClient,
                typeof(global::G.UpdateClientParams),
                DeleteClient,
                typeof(global::G.DeleteClientParams),
                ListStaff,
                typeof(global::G.ListStaffParams),
                CreateStaff,
                typeof(global::G.CreateStaffParams),
                UpdateStaff,
                typeof(global::G.UpdateStaffParams),
                DeleteStaff,
                typeof(global::G.DeleteStaffParams),
                ListAssets,
                typeof(global::G.ListAssetsParams),
                CreateAsset,
                typeof(global::G.CreateAssetParams),
                UpdateAsset,
                typeof(global::G.UpdateAssetParams),
                DeleteAsset,
                typeof(global::G.DeleteAssetParams),
                ListServices,
                typeof(global::G.ListServicesParams),
                CreateService,
                typeof(global::G.CreateServiceParams),
                UpdateService,
                typeof(global::G.UpdateServiceParams),
                DeleteService,
                typeof(global::G.DeleteServiceParams),
                ListProducts,
                typeof(global::G.ListProductsParams),
                CreateProduct,
                typeof(global::G.CreateProductParams),
                UpdateProduct,
                typeof(global::G.UpdateProductParams),
                DeleteProduct,
                typeof(global::G.DeleteProductParams),
                CheckServiceAvailability,
                typeof(global::G.CheckServiceAvailabilityParams),
                CreateClientAppointment,
                typeof(global::G.CreateClientAppointmentParams),
                GetClientAppointments,
                typeof(global::G.GetClientAppointmentsParams),
                ListCalendarEvents,
                typeof(global::G.ListCalendarEventsParams),
                UpdateCalendarEvent,
                typeof(global::G.UpdateCalendarEventParams),
                DeleteCalendarEvent,
                typeof(global::G.DeleteCalendarEventParams),
                ListRentalServices,
                typeof(global::G.ListRentalServicesParams),
                CheckRentalAvailability,
                typeof(global::G.CheckRentalAvailabilityParams),
                CreateRentalBooking,
                typeof(global::G.CreateRentalBookingParams),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Params other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SearchClientsParams?>.Default.Equals(SearchClients, other.SearchClients) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListClientsParams?>.Default.Equals(ListClients, other.ListClients) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetClientByPhoneParams?>.Default.Equals(GetClientByPhone, other.GetClientByPhone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateClientParams?>.Default.Equals(CreateClient, other.CreateClient) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateClientParams?>.Default.Equals(UpdateClient, other.UpdateClient) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteClientParams?>.Default.Equals(DeleteClient, other.DeleteClient) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListStaffParams?>.Default.Equals(ListStaff, other.ListStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateStaffParams?>.Default.Equals(CreateStaff, other.CreateStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateStaffParams?>.Default.Equals(UpdateStaff, other.UpdateStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteStaffParams?>.Default.Equals(DeleteStaff, other.DeleteStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListAssetsParams?>.Default.Equals(ListAssets, other.ListAssets) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAssetParams?>.Default.Equals(CreateAsset, other.CreateAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateAssetParams?>.Default.Equals(UpdateAsset, other.UpdateAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteAssetParams?>.Default.Equals(DeleteAsset, other.DeleteAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListServicesParams?>.Default.Equals(ListServices, other.ListServices) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateServiceParams?>.Default.Equals(CreateService, other.CreateService) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateServiceParams?>.Default.Equals(UpdateService, other.UpdateService) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteServiceParams?>.Default.Equals(DeleteService, other.DeleteService) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListProductsParams?>.Default.Equals(ListProducts, other.ListProducts) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateProductParams?>.Default.Equals(CreateProduct, other.CreateProduct) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateProductParams?>.Default.Equals(UpdateProduct, other.UpdateProduct) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteProductParams?>.Default.Equals(DeleteProduct, other.DeleteProduct) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CheckServiceAvailabilityParams?>.Default.Equals(CheckServiceAvailability, other.CheckServiceAvailability) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateClientAppointmentParams?>.Default.Equals(CreateClientAppointment, other.CreateClientAppointment) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetClientAppointmentsParams?>.Default.Equals(GetClientAppointments, other.GetClientAppointments) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListCalendarEventsParams?>.Default.Equals(ListCalendarEvents, other.ListCalendarEvents) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateCalendarEventParams?>.Default.Equals(UpdateCalendarEvent, other.UpdateCalendarEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteCalendarEventParams?>.Default.Equals(DeleteCalendarEvent, other.DeleteCalendarEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListRentalServicesParams?>.Default.Equals(ListRentalServices, other.ListRentalServices) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CheckRentalAvailabilityParams?>.Default.Equals(CheckRentalAvailability, other.CheckRentalAvailability) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateRentalBookingParams?>.Default.Equals(CreateRentalBooking, other.CreateRentalBooking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params obj1, Params obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params obj1, Params obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params o && Equals(o);
        }
    }
}
