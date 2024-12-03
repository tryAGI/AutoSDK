//HintName: JsonConverters.PackagesListPackagesForAuthenticatedUserPackageTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PackagesListPackagesForAuthenticatedUserPackageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PackagesListPackagesForAuthenticatedUserPackageType?>
    {
        /// <inheritdoc />
        public override global::G.PackagesListPackagesForAuthenticatedUserPackageType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.PackagesListPackagesForAuthenticatedUserPackageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PackagesListPackagesForAuthenticatedUserPackageType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PackagesListPackagesForAuthenticatedUserPackageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PackagesListPackagesForAuthenticatedUserPackageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
