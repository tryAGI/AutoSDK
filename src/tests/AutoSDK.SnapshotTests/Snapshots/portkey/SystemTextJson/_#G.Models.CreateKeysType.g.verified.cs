//HintName: G.Models.CreateKeysType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKeysType
    {
        /// <summary>
        /// 
        /// </summary>
        Organisation,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKeysTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKeysType value)
        {
            return value switch
            {
                CreateKeysType.Organisation => "organisation",
                CreateKeysType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKeysType? ToEnum(string value)
        {
            return value switch
            {
                "organisation" => CreateKeysType.Organisation,
                "workspace" => CreateKeysType.Workspace,
                _ => null,
            };
        }
    }
}