// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Cat
    /// </summary>
    public partial class Cat : Animal, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat" /> class.
        /// </summary>
        /// <param name="className">className</param>
        /// <param name="declawed">declawed</param>
        /// <param name="color">color (default to &quot;red&quot;)</param>
        [JsonConstructor]
        public Cat(string className, bool declawed, string color = "red") : base(className, color)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (declawed == null)
                throw new ArgumentNullException("declawed is a required property for Cat and cannot be null.");

            if (className == null)
                throw new ArgumentNullException("className is a required property for Cat and cannot be null.");

            if (color == null)
                throw new ArgumentNullException("color is a required property for Cat and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Declawed = declawed;
        }

        /// <summary>
        /// Gets or Sets Declawed
        /// </summary>
        [JsonPropertyName("declawed")]
        public bool Declawed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Cat {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Declawed: ").Append(Declawed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type Cat
    /// </summary>
    public class CatJsonConverter : JsonConverter<Cat>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Cat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            string className = default;
            bool declawed = default;
            string color = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName && currentDepth == reader.CurrentDepth - 1)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "className":
                            className = reader.GetString();
                            break;
                        case "declawed":
                            declawed = reader.GetBoolean();
                            break;
                        case "color":
                            color = reader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Cat(className, declawed, color);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cat"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Cat cat, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("className", cat.ClassName);
            writer.WriteBoolean("declawed", cat.Declawed);
            writer.WriteString("color", cat.Color);

            writer.WriteEndObject();
        }
    }
}
