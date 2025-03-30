//HintName: G.Models.GroupExampleRunsByField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroupExampleRunsByField
    {
        /// <summary>
        /// 
        /// </summary>
        RunMetadata,
        /// <summary>
        /// 
        /// </summary>
        ExampleMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupExampleRunsByFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupExampleRunsByField value)
        {
            return value switch
            {
                GroupExampleRunsByField.RunMetadata => "run_metadata",
                GroupExampleRunsByField.ExampleMetadata => "example_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupExampleRunsByField? ToEnum(string value)
        {
            return value switch
            {
                "run_metadata" => GroupExampleRunsByField.RunMetadata,
                "example_metadata" => GroupExampleRunsByField.ExampleMetadata,
                _ => null,
            };
        }
    }
}