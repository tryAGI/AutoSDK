//HintName: G.Models.CreateUploadsRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of upload to create
    /// </summary>
    public enum CreateUploadsRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUploadsRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUploadsRequestType value)
        {
            return value switch
            {
                CreateUploadsRequestType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUploadsRequestType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => CreateUploadsRequestType.Ephemeral,
                _ => null,
            };
        }
    }
}