//HintName: G.JsonConverters.OrgRulesetConditions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OrgRulesetConditionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrgRulesetConditions>
    {
        /// <inheritdoc />
        public override global::G.OrgRulesetConditions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.OrgRulesetConditions(
                value1,
                value2,
                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrgRulesetConditions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}