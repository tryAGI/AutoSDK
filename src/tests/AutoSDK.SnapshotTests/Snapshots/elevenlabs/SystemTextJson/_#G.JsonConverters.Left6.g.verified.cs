//HintName: G.JsonConverters.Left6.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Left6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Left6>
    {
        /// <inheritdoc />
        public override global::G.Left6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ASTStringNodeOutput? stringLiteral = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTStringNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTStringNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTStringNodeOutput)}");
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTNumberNodeOutput? numberLiteral = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNumberNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNumberNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTNumberNodeOutput)}");
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTBooleanNodeOutput? booleanLiteral = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTBooleanNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTBooleanNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTBooleanNodeOutput)}");
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTLLMNodeOutput? llm = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLLMNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLLMNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTLLMNodeOutput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTDynamicVariableNodeOutput? dynamicVariable = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTDynamicVariableNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTDynamicVariableNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTDynamicVariableNodeOutput)}");
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTOrOperatorNodeOutput? orOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTOrOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTOrOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTOrOperatorNodeOutput)}");
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTAndOperatorNodeOutput? andOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTAndOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTAndOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTAndOperatorNodeOutput)}");
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTEqualsOperatorNodeOutput? eqOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTEqualsOperatorNodeOutput)}");
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTNotEqualsOperatorNodeOutput? neqOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNotEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNotEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTNotEqualsOperatorNodeOutput)}");
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTGreaterThanOperatorNodeOutput? gtOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTGreaterThanOperatorNodeOutput)}");
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTLessThanOperatorNodeOutput? ltOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTLessThanOperatorNodeOutput)}");
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTGreaterThanOrEqualsOperatorNodeOutput? gteOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOrEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput)}");
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTLessThanOrEqualsOperatorNodeOutput? lteOperator = default;
            if (discriminator?.Type == global::G.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOrEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTLessThanOrEqualsOperatorNodeOutput)}");
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Left6(
                discriminator?.Type,
                stringLiteral,

                numberLiteral,

                booleanLiteral,

                llm,

                dynamicVariable,

                orOperator,

                andOperator,

                eqOperator,

                neqOperator,

                gtOperator,

                ltOperator,

                gteOperator,

                lteOperator
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Left6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTStringNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTStringNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTStringNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral!, typeInfo);
            }
            else if (value.IsNumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNumberNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNumberNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTNumberNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral!, typeInfo);
            }
            else if (value.IsBooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTBooleanNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTBooleanNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTBooleanNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral!, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLLMNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLLMNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTLLMNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTDynamicVariableNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTDynamicVariableNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTDynamicVariableNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable!, typeInfo);
            }
            else if (value.IsOrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTOrOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTOrOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTOrOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator!, typeInfo);
            }
            else if (value.IsAndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTAndOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTAndOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTAndOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator!, typeInfo);
            }
            else if (value.IsEqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator!, typeInfo);
            }
            else if (value.IsNeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNotEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNotEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTNotEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator!, typeInfo);
            }
            else if (value.IsGtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTGreaterThanOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator!, typeInfo);
            }
            else if (value.IsLtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTLessThanOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator!, typeInfo);
            }
            else if (value.IsGteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOrEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator!, typeInfo);
            }
            else if (value.IsLteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOrEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTLessThanOrEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator!, typeInfo);
            }
        }
    }
}