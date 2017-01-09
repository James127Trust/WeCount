﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PITCSurveyLib.Models
{
	/// <summary>
	/// Client-side response model for the survey response from a given interviewee.
	/// Contains only identifiers needed for the responses.
	/// </summary>
	public class SurveyResponseModel
	{
		/// <summary>
		/// Database ID of Survey this response is for.
		/// Obtained from the server via the SurveyModel.
		/// </summary>
		public int SurveyID { get; set; }

		/// <summary>
		/// The version of the survey this response matches.
		/// </summary>
		public int Survey_Version { get; set; }

		/// <summary>
		/// Identifier of the Interviewer conducting this survey.
		/// </summary>
		[Obsolete("User's auth token handled by App Service Authentication, no need to pass.")]
		[JsonIgnore()]
		public String InterviewerID { get; set; }

		public DateTimeOffset StartTime { get; set; }
		public DateTimeOffset EndTime { get; set; }

		/// <summary>
		/// Unique GUID generated client-side for each response.
		/// Will ensure responses aren't uploaded multiple times due to bad connection, etc.
		/// </summary>
		public Guid ResponseIdentifier { get; set; }

	    /// <summary>
	    /// GPS coordinates where survey response is completed, if available.
	    /// </summary>
	    public GPSLocation GPSLocation { get; set; } = new GPSLocation();

		/// <summary>
		/// Additional notes about the location. Optional.
		/// </summary>
		public String LocationNotes { get; set; }

	    /// <summary>
	    /// Nearest street address / cross street to survey location.
	    /// This may be auto-generated by geocoding API, but should be user-editable for correction.
	    /// TODO: Consider a "Use Last Address" option in the client app, to prevent tedious data re-entry when completing multiple survey responses at the same location.
	    /// </summary>
	    public Address NearestAddress { get; set; } = new Address();

		// While most questions only allow one answer, this will allow multiple-choice responses.
		public IList<SurveyQuestionResponseModel> QuestionResponses { get; set; } = new List<SurveyQuestionResponseModel>();
	}

	/// <summary>
	/// Client-side response model for individual survey question responses from a given interviewee.
	/// </summary>
	public class SurveyQuestionResponseModel
	{
		public int QuestionID { get; set; }

		public IList<SurveyQuestionAnswerChoiceResponseModel> AnswerChoiceResponses { get; set; } = new List<SurveyQuestionAnswerChoiceResponseModel>();
	}

	/// <summary>
	/// Client-side responsemodel for possible answer choices for each question to be displayed for each interviewee.
	/// </summary>
	public class SurveyQuestionAnswerChoiceResponseModel
	{
		public int QuestionID { get; set; }                             // Database ID
		public int AnswerChoiceID { get; set; }                         // Database ID
		public String AdditionalAnswerData { get; set; }                // Should be formatted / validated according to specified AdditionalAnswerData
	}
}
