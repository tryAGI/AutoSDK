﻿//HintName: G.JsonConverters.ModelPublicServiceGetNamespaceModelView.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelPublicServiceGetNamespaceModelViewJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelPublicServiceGetNamespaceModelView>
    {
        /// <inheritdoc />
        public override global::G.ModelPublicServiceGetNamespaceModelView Read(
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
                        return global::G.ModelPublicServiceGetNamespaceModelViewExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ModelPublicServiceGetNamespaceModelView)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ModelPublicServiceGetNamespaceModelView);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelPublicServiceGetNamespaceModelView value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ModelPublicServiceGetNamespaceModelViewExtensions.ToValueString(value));
        }
    }
}
