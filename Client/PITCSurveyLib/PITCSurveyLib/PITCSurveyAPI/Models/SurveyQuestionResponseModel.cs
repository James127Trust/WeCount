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

    public partial class SurveyQuestionResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the SurveyQuestionResponseModel
        /// class.
        /// </summary>
        public SurveyQuestionResponseModel() { }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestionResponseModel
        /// class.
        /// </summary>
        public SurveyQuestionResponseModel(int? questionID = default(int?), IList<SurveyQuestionAnswerChoiceResponseModel> answerChoiceResponses = default(IList<SurveyQuestionAnswerChoiceResponseModel>))
        {
            QuestionID = questionID;
            AnswerChoiceResponses = answerChoiceResponses;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuestionID")]
        public int? QuestionID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AnswerChoiceResponses")]
        public IList<SurveyQuestionAnswerChoiceResponseModel> AnswerChoiceResponses { get; set; }

    }
}
