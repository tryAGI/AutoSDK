//HintName: G.Models.PayloadSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All possible names of payload types
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PayloadSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bool")]
        Bool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="datetime")]
        Datetime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="geo")]
        Geo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="keyword")]
        Keyword,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uuid")]
        Uuid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PayloadSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PayloadSchemaType value)
        {
            return value switch
            {
                PayloadSchemaType.Bool => "bool",
                PayloadSchemaType.Datetime => "datetime",
                PayloadSchemaType.Float => "float",
                PayloadSchemaType.Geo => "geo",
                PayloadSchemaType.Integer => "integer",
                PayloadSchemaType.Keyword => "keyword",
                PayloadSchemaType.Text => "text",
                PayloadSchemaType.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PayloadSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "bool" => PayloadSchemaType.Bool,
                "datetime" => PayloadSchemaType.Datetime,
                "float" => PayloadSchemaType.Float,
                "geo" => PayloadSchemaType.Geo,
                "integer" => PayloadSchemaType.Integer,
                "keyword" => PayloadSchemaType.Keyword,
                "text" => PayloadSchemaType.Text,
                "uuid" => PayloadSchemaType.Uuid,
                _ => null,
            };
        }
    }
}