﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace PITCSurveyLib.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class SurveyQuestionModel
    {
        /// <summary>
        /// Initializes a new instance of the SurveyQuestionModel class.
        /// </summary>
        public SurveyQuestionModel() { }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestionModel class.
        /// </summary>
        public SurveyQuestionModel(int? questionID = default(int?), string questionNum = default(string), string questionText = default(string), string questionHelpText = default(string), bool? allowMultipleAnswers = default(bool?), IList<SurveyQuestionAnswerChoiceModel> answerChoices = default(IList<SurveyQuestionAnswerChoiceModel>))
        {
            QuestionID = questionID;
            QuestionNum = questionNum;
            QuestionText = questionText;
            QuestionHelpText = questionHelpText;
            AllowMultipleAnswers = allowMultipleAnswers;
            AnswerChoices = answerChoices;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuestionID")]
        public int? QuestionID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuestionNum")]
        public string QuestionNum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuestionText")]
        public string QuestionText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuestionHelpText")]
        public string QuestionHelpText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowMultipleAnswers")]
        public bool? AllowMultipleAnswers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AnswerChoices")]
        public IList<SurveyQuestionAnswerChoiceModel> AnswerChoices { get; set; }

    }
}
