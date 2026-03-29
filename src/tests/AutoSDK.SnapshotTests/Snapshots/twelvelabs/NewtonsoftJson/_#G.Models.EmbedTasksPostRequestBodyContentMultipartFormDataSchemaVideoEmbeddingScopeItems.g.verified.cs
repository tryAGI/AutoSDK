//HintName: G.Models.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems value)
        {
            return value switch
            {
                EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems.Clip => "clip",
                EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "clip" => EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems.Clip,
                "video" => EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems.Video,
                _ => null,
            };
        }
    }
}