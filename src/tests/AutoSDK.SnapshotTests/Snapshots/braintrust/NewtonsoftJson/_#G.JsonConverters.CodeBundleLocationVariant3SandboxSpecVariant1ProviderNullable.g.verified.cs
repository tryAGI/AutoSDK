//HintName: G.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider?>
    {
        /// <inheritdoc />
        public override global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.CodeBundleLocationVariant3SandboxSpecVariant1ProviderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CodeBundleLocationVariant3SandboxSpecVariant1ProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
