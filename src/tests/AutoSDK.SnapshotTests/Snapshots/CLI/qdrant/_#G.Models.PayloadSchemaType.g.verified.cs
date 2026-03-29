//HintName: G.Models.PayloadSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All possible names of payload types
    /// </summary>
    public enum PayloadSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Datetime,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Geo,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Keyword,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
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