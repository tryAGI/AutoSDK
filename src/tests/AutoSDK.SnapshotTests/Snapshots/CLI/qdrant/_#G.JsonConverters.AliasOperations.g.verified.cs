//HintName: G.JsonConverters.AliasOperations.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AliasOperationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AliasOperations>
    {
        /// <inheritdoc />
        public override global::G.AliasOperations Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("create_alias")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("delete_alias")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("rename_alias")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.CreateAliasOperation? createOperation = default;
            global::G.DeleteAliasOperation? deleteOperation = default;
            global::G.RenameAliasOperation? renameOperation = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAliasOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAliasOperation).Name}");
                        createOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteAliasOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteAliasOperation).Name}");
                        deleteOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenameAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenameAliasOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenameAliasOperation).Name}");
                        renameOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createOperation == null && deleteOperation == null && renameOperation == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAliasOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAliasOperation).Name}");
                    createOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteAliasOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteAliasOperation).Name}");
                    deleteOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenameAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenameAliasOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenameAliasOperation).Name}");
                    renameOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AliasOperations(
                createOperation,

                deleteOperation,

                renameOperation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AliasOperations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAliasOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAliasOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateOperation!, typeInfo);
            }
            else if (value.IsDeleteOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeleteAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeleteAliasOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeleteAliasOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteOperation!, typeInfo);
            }
            else if (value.IsRenameOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RenameAliasOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RenameAliasOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RenameAliasOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenameOperation!, typeInfo);
            }
        }
    }
}