//HintName: G.Models.BreakdownTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to break down the information. Cannot be "user" or "api_key" if include_workspace_metrics is False.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BreakdownTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all_api_keys")]
        AllApiKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_keys")]
        ApiKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groups")]
        Groups,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="has_api_key")]
        HasApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="product_type")]
        ProductType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="region")]
        Region,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reporting_workspace_id")]
        ReportingWorkspaceId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request_queue")]
        RequestQueue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request_source")]
        RequestSource,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resource")]
        Resource,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subresource_id")]
        SubresourceId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice")]
        Voice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_multiplier")]
        VoiceMultiplier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BreakdownTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BreakdownTypes value)
        {
            return value switch
            {
                BreakdownTypes.AllApiKeys => "all_api_keys",
                BreakdownTypes.ApiKeys => "api_keys",
                BreakdownTypes.Groups => "groups",
                BreakdownTypes.HasApiKey => "has_api_key",
                BreakdownTypes.Model => "model",
                BreakdownTypes.None => "none",
                BreakdownTypes.ProductType => "product_type",
                BreakdownTypes.Region => "region",
                BreakdownTypes.ReportingWorkspaceId => "reporting_workspace_id",
                BreakdownTypes.RequestQueue => "request_queue",
                BreakdownTypes.RequestSource => "request_source",
                BreakdownTypes.Resource => "resource",
                BreakdownTypes.SubresourceId => "subresource_id",
                BreakdownTypes.User => "user",
                BreakdownTypes.Voice => "voice",
                BreakdownTypes.VoiceMultiplier => "voice_multiplier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BreakdownTypes? ToEnum(string value)
        {
            return value switch
            {
                "all_api_keys" => BreakdownTypes.AllApiKeys,
                "api_keys" => BreakdownTypes.ApiKeys,
                "groups" => BreakdownTypes.Groups,
                "has_api_key" => BreakdownTypes.HasApiKey,
                "model" => BreakdownTypes.Model,
                "none" => BreakdownTypes.None,
                "product_type" => BreakdownTypes.ProductType,
                "region" => BreakdownTypes.Region,
                "reporting_workspace_id" => BreakdownTypes.ReportingWorkspaceId,
                "request_queue" => BreakdownTypes.RequestQueue,
                "request_source" => BreakdownTypes.RequestSource,
                "resource" => BreakdownTypes.Resource,
                "subresource_id" => BreakdownTypes.SubresourceId,
                "user" => BreakdownTypes.User,
                "voice" => BreakdownTypes.Voice,
                "voice_multiplier" => BreakdownTypes.VoiceMultiplier,
                _ => null,
            };
        }
    }
}