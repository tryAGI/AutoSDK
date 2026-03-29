//HintName: G.Models.SupabaseCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is for supabase storage.
    /// </summary>
    public enum SupabaseCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Supabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupabaseCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupabaseCredentialProvider value)
        {
            return value switch
            {
                SupabaseCredentialProvider.Supabase => "supabase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupabaseCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "supabase" => SupabaseCredentialProvider.Supabase,
                _ => null,
            };
        }
    }
}