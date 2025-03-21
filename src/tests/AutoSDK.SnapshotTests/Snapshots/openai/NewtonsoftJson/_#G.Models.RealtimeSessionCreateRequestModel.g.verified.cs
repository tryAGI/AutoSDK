//HintName: G.Models.RealtimeSessionCreateRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Realtime model used for this session.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-realtime-preview")]
        Gpt4oRealtimePreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-realtime-preview-2024-10-01")]
        Gpt4oRealtimePreview20241001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-realtime-preview-2024-12-17")]
        Gpt4oRealtimePreview20241217,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-realtime-preview")]
        Gpt4oMiniRealtimePreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-realtime-preview-2024-12-17")]
        Gpt4oMiniRealtimePreview20241217,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestModel value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview => "gpt-4o-realtime-preview",
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241001 => "gpt-4o-realtime-preview-2024-10-01",
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241217 => "gpt-4o-realtime-preview-2024-12-17",
                RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview => "gpt-4o-mini-realtime-preview",
                RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview20241217 => "gpt-4o-mini-realtime-preview-2024-12-17",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-realtime-preview" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview,
                "gpt-4o-realtime-preview-2024-10-01" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241001,
                "gpt-4o-realtime-preview-2024-12-17" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241217,
                "gpt-4o-mini-realtime-preview" => RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview,
                "gpt-4o-mini-realtime-preview-2024-12-17" => RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview20241217,
                _ => null,
            };
        }
    }
}