﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace PITCSurveyLib
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for PITCSurveyAPI.
    /// </summary>
    public static partial class PITCSurveyAPIExtensions
    {
            /// <summary>
            /// Submit a completed Survey Response.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='surveyResponse'>
            /// </param>
            public static void PostSurveyResponse(this IPITCSurveyAPI operations, SurveyResponseModel surveyResponse)
            {
                Task.Factory.StartNew(s => ((IPITCSurveyAPI)s).PostSurveyResponseAsync(surveyResponse), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submit a completed Survey Response.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='surveyResponse'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostSurveyResponseAsync(this IPITCSurveyAPI operations, SurveyResponseModel surveyResponse, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostSurveyResponseWithHttpMessagesAsync(surveyResponse, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a list of available Surveys and metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeOnly'>
            /// </param>
            public static IList<SurveySummaryModel> GetAllSurveys(this IPITCSurveyAPI operations, bool activeOnly)
            {
                return Task.Factory.StartNew(s => ((IPITCSurveyAPI)s).GetAllSurveysAsync(activeOnly), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of available Surveys and metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeOnly'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SurveySummaryModel>> GetAllSurveysAsync(this IPITCSurveyAPI operations, bool activeOnly, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllSurveysWithHttpMessagesAsync(activeOnly, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Import a new / updated Survey.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='survey'>
            /// </param>
            public static object PostSurvey(this IPITCSurveyAPI operations, SurveyModel survey)
            {
                return Task.Factory.StartNew(s => ((IPITCSurveyAPI)s).PostSurveyAsync(survey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Import a new / updated Survey.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='survey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostSurveyAsync(this IPITCSurveyAPI operations, SurveyModel survey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostSurveyWithHttpMessagesAsync(survey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the full body of the specified Survey.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static SurveyModel GetSurveyByID(this IPITCSurveyAPI operations, int id)
            {
                return Task.Factory.StartNew(s => ((IPITCSurveyAPI)s).GetSurveyByIDAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the full body of the specified Survey.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SurveyModel> GetSurveyByIDAsync(this IPITCSurveyAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSurveyByIDWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static VolunteerModel GetAuthenticatedVolunteer(this IPITCSurveyAPI operations)
            {
                return Task.Factory.StartNew(s => ((IPITCSurveyAPI)s).GetAuthenticatedVolunteerAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VolunteerModel> GetAuthenticatedVolunteerAsync(this IPITCSurveyAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthenticatedVolunteerWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='volunteer'>
            /// </param>
            public static void UpdateVolunteer(this IPITCSurveyAPI operations, VolunteerModel volunteer)
            {
                Task.Factory.StartNew(s => ((IPITCSurveyAPI)s).UpdateVolunteerAsync(volunteer), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='volunteer'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateVolunteerAsync(this IPITCSurveyAPI operations, VolunteerModel volunteer, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.UpdateVolunteerWithHttpMessagesAsync(volunteer, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
