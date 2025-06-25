﻿//HintName: G.Models.RequestTextBlockCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTextBlockCitationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                RequestTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                RequestTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                RequestTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => RequestTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => RequestTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => RequestTextBlockCitationDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}