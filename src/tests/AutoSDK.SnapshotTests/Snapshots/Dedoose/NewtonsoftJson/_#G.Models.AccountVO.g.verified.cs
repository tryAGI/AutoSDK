//HintName: G.Models.AccountVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpupm")]
        public double? Cpupm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPayment")]
        public global::System.DateTime? LastPayment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPastDue")]
        public bool? IsPastDue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pastDueStartDate")]
        public global::System.DateTime? PastDueStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crRunDate")]
        public global::System.DateTime? CrRunDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPastDueNoticeDate")]
        public global::System.DateTime? LastPastDueNoticeDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoBillRefTransId")]
        public string? AutoBillRefTransId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoBillCVV2")]
        public string? AutoBillCVV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoBillActive")]
        public bool? AutoBillActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpupmOverride")]
        public double? CpupmOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpupmOverrideEnd")]
        public global::System.DateTime? CpupmOverrideEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcePasswordPolicy")]
        public bool? EnforcePasswordPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_MinLength")]
        public int? PwPolicyMinLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_RequireChar")]
        public bool? PwPolicyRequireChar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_RequireUpper")]
        public bool? PwPolicyRequireUpper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_RequireNumber")]
        public bool? PwPolicyRequireNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_RequireSymbol")]
        public bool? PwPolicyRequireSymbol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_MaxAge")]
        public int? PwPolicyMaxAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_Require2Auth")]
        public bool? PwPolicyRequire2Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_2AuthOnRelog")]
        public bool? PwPolicy2AuthOnRelog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pwPolicy_IdleTimeout")]
        public int? PwPolicyIdleTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adminIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AdminIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountVO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createStamp"></param>
        /// <param name="credits"></param>
        /// <param name="cpupm"></param>
        /// <param name="lastPayment"></param>
        /// <param name="isActive"></param>
        /// <param name="isPastDue"></param>
        /// <param name="pastDueStartDate"></param>
        /// <param name="crRunDate"></param>
        /// <param name="lastPastDueNoticeDate"></param>
        /// <param name="autoBillRefTransId"></param>
        /// <param name="autoBillCVV2"></param>
        /// <param name="autoBillActive"></param>
        /// <param name="cpupmOverride"></param>
        /// <param name="cpupmOverrideEnd"></param>
        /// <param name="enforcePasswordPolicy"></param>
        /// <param name="pwPolicyMinLength"></param>
        /// <param name="pwPolicyRequireChar"></param>
        /// <param name="pwPolicyRequireUpper"></param>
        /// <param name="pwPolicyRequireNumber"></param>
        /// <param name="pwPolicyRequireSymbol"></param>
        /// <param name="pwPolicyMaxAge"></param>
        /// <param name="pwPolicyRequire2Auth"></param>
        /// <param name="pwPolicy2AuthOnRelog"></param>
        /// <param name="pwPolicyIdleTimeout"></param>
        /// <param name="adminIds"></param>
        public AccountVO(
            global::System.Guid? id,
            global::System.DateTime? createStamp,
            double? credits,
            double? cpupm,
            global::System.DateTime? lastPayment,
            bool? isActive,
            bool? isPastDue,
            global::System.DateTime? pastDueStartDate,
            global::System.DateTime? crRunDate,
            global::System.DateTime? lastPastDueNoticeDate,
            string? autoBillRefTransId,
            string? autoBillCVV2,
            bool? autoBillActive,
            double? cpupmOverride,
            global::System.DateTime? cpupmOverrideEnd,
            bool? enforcePasswordPolicy,
            int? pwPolicyMinLength,
            bool? pwPolicyRequireChar,
            bool? pwPolicyRequireUpper,
            bool? pwPolicyRequireNumber,
            bool? pwPolicyRequireSymbol,
            int? pwPolicyMaxAge,
            bool? pwPolicyRequire2Auth,
            bool? pwPolicy2AuthOnRelog,
            int? pwPolicyIdleTimeout,
            global::System.Collections.Generic.IList<global::System.Guid>? adminIds)
        {
            this.Id = id;
            this.CreateStamp = createStamp;
            this.Credits = credits;
            this.Cpupm = cpupm;
            this.LastPayment = lastPayment;
            this.IsActive = isActive;
            this.IsPastDue = isPastDue;
            this.PastDueStartDate = pastDueStartDate;
            this.CrRunDate = crRunDate;
            this.LastPastDueNoticeDate = lastPastDueNoticeDate;
            this.AutoBillRefTransId = autoBillRefTransId;
            this.AutoBillCVV2 = autoBillCVV2;
            this.AutoBillActive = autoBillActive;
            this.CpupmOverride = cpupmOverride;
            this.CpupmOverrideEnd = cpupmOverrideEnd;
            this.EnforcePasswordPolicy = enforcePasswordPolicy;
            this.PwPolicyMinLength = pwPolicyMinLength;
            this.PwPolicyRequireChar = pwPolicyRequireChar;
            this.PwPolicyRequireUpper = pwPolicyRequireUpper;
            this.PwPolicyRequireNumber = pwPolicyRequireNumber;
            this.PwPolicyRequireSymbol = pwPolicyRequireSymbol;
            this.PwPolicyMaxAge = pwPolicyMaxAge;
            this.PwPolicyRequire2Auth = pwPolicyRequire2Auth;
            this.PwPolicy2AuthOnRelog = pwPolicy2AuthOnRelog;
            this.PwPolicyIdleTimeout = pwPolicyIdleTimeout;
            this.AdminIds = adminIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountVO" /> class.
        /// </summary>
        public AccountVO()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.AccountVO? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AccountVO>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.AccountVO?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.AccountVO?>(serializer.Deserialize<global::G.AccountVO>(jsonReader));
        }

    }
}