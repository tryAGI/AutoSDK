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
        ExampleMetadata,
        /// <summary>
        /// 
        /// </summary>
        RunMetadata,
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
                GroupExampleRunsByField.ExampleMetadata => "example_metadata",
                GroupExampleRunsByField.RunMetadata => "run_metadata",
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
                "example_metadata" => GroupExampleRunsByField.ExampleMetadata,
                "run_metadata" => GroupExampleRunsByField.RunMetadata,
                _ => null,
            };
        }
    }
}