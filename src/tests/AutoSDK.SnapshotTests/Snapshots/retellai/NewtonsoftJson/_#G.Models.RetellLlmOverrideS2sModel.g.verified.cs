//HintName: G.Models.RetellLlmOverrideS2sModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select the underlying speech to speech model. Can only set this or model, not both.<br/>
    /// Example: gpt-realtime-1.5
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetellLlmOverrideS2sModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-realtime")]
        GptRealtime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-realtime-1.5")]
        GptRealtime15,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-realtime-mini")]
        GptRealtimeMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetellLlmOverrideS2sModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetellLlmOverrideS2sModel value)
        {
            return value switch
            {
                RetellLlmOverrideS2sModel.GptRealtime => "gpt-realtime",
                RetellLlmOverrideS2sModel.GptRealtime15 => "gpt-realtime-1.5",
                RetellLlmOverrideS2sModel.GptRealtimeMini => "gpt-realtime-mini",
                RetellLlmOverrideS2sModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetellLlmOverrideS2sModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime" => RetellLlmOverrideS2sModel.GptRealtime,
                "gpt-realtime-1.5" => RetellLlmOverrideS2sModel.GptRealtime15,
                "gpt-realtime-mini" => RetellLlmOverrideS2sModel.GptRealtimeMini,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => RetellLlmOverrideS2sModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}