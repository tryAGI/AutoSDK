//HintName: G.JsonConverters.Right10.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Right10JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Right10>
    {
        /// <inheritdoc />
        public override global::G.Right10 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator>(ref readerCopy, options);

            global::G.ASTStringNodeOutput? stringLiteral = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral)
            {
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTStringNodeOutput>(ref reader, options);
            }
            global::G.ASTNumberNodeOutput? numberLiteral = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral)
            {
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTNumberNodeOutput>(ref reader, options);
            }
            global::G.ASTBooleanNodeOutput? booleanLiteral = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral)
            {
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTBooleanNodeOutput>(ref reader, options);
            }
            global::G.ASTLLMNodeOutput? llm = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLLMNodeOutput>(ref reader, options);
            }
            global::G.ASTDynamicVariableNodeOutput? dynamicVariable = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable)
            {
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTDynamicVariableNodeOutput>(ref reader, options);
            }
            global::G.ASTOrOperatorNodeOutput? orOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator)
            {
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTOrOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTAndOperatorNodeOutput? andOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator)
            {
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTAndOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTEqualsOperatorNodeOutput? eqOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator)
            {
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTNotEqualsOperatorNodeOutput? neqOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator)
            {
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTNotEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTGreaterThanOperatorNodeOutput? gtOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator)
            {
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTGreaterThanOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTLessThanOperatorNodeOutput? ltOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator)
            {
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLessThanOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTGreaterThanOrEqualsOperatorNodeOutput? gteOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator)
            {
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTGreaterThanOrEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::G.ASTLessThanOrEqualsOperatorNodeOutput? lteOperator = default;
            if (discriminator?.Type == global::G.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator)
            {
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLessThanOrEqualsOperatorNodeOutput>(ref reader, options);
            }

            var __value = new global::G.Right10(
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
            global::G.Right10 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStringLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeof(global::G.ASTStringNodeOutput), options);
            }
            else if (value.IsNumberLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeof(global::G.ASTNumberNodeOutput), options);
            }
            else if (value.IsBooleanLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeof(global::G.ASTBooleanNodeOutput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.ASTLLMNodeOutput), options);
            }
            else if (value.IsDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeof(global::G.ASTDynamicVariableNodeOutput), options);
            }
            else if (value.IsOrOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeof(global::G.ASTOrOperatorNodeOutput), options);
            }
            else if (value.IsAndOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeof(global::G.ASTAndOperatorNodeOutput), options);
            }
            else if (value.IsEqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeof(global::G.ASTEqualsOperatorNodeOutput), options);
            }
            else if (value.IsNeqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeof(global::G.ASTNotEqualsOperatorNodeOutput), options);
            }
            else if (value.IsGtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeof(global::G.ASTGreaterThanOperatorNodeOutput), options);
            }
            else if (value.IsLtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeof(global::G.ASTLessThanOperatorNodeOutput), options);
            }
            else if (value.IsGteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeOutput), options);
            }
            else if (value.IsLteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeof(global::G.ASTLessThanOrEqualsOperatorNodeOutput), options);
            }
        }
    }
}