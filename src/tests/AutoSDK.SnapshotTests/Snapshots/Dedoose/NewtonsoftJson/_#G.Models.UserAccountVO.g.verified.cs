//HintName: G.Models.UserAccountVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserAccountVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPastDue")]
        public bool? IsPastDue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDisabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountUserCount")]
        public int? AccountUserCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountCPUPM")]
        public double? AccountCPUPM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentBalance")]
        public double? CurrentBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPaymentDate")]
        public global::System.DateTime? LastPaymentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPastDueNoticeDate")]
        public global::System.DateTime? LastPastDueNoticeDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastPaymentAmmount")]
        public double? LastPaymentAmmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPastLateGracePeriod")]
        public bool? IsPastLateGracePeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountVO" /> class.
        /// </summary>
        /// <param name="isPastDue"></param>
        /// <param name="isDisabled"></param>
        /// <param name="accountId"></param>
        /// <param name="accountUserCount"></param>
        /// <param name="accountCPUPM"></param>
        /// <param name="currentBalance"></param>
        /// <param name="lastPaymentDate"></param>
        /// <param name="lastPastDueNoticeDate"></param>
        /// <param name="lastPaymentAmmount"></param>
        /// <param name="isPastLateGracePeriod"></param>
        public UserAccountVO(
            bool? isPastDue,
            bool? isDisabled,
            global::System.Guid? accountId,
            int? accountUserCount,
            double? accountCPUPM,
            double? currentBalance,
            global::System.DateTime? lastPaymentDate,
            global::System.DateTime? lastPastDueNoticeDate,
            double? lastPaymentAmmount,
            bool? isPastLateGracePeriod)
        {
            this.IsPastDue = isPastDue;
            this.IsDisabled = isDisabled;
            this.AccountId = accountId;
            this.AccountUserCount = accountUserCount;
            this.AccountCPUPM = accountCPUPM;
            this.CurrentBalance = currentBalance;
            this.LastPaymentDate = lastPaymentDate;
            this.LastPastDueNoticeDate = lastPastDueNoticeDate;
            this.LastPaymentAmmount = lastPaymentAmmount;
            this.IsPastLateGracePeriod = isPastLateGracePeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountVO" /> class.
        /// </summary>
        public UserAccountVO()
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
        public static global::G.UserAccountVO? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UserAccountVO>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.UserAccountVO?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.UserAccountVO?>(serializer.Deserialize<global::G.UserAccountVO>(jsonReader));
        }

    }
}