﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;

namespace PITCSurveySvc.Entities
{
    public class PITCSurveyContext: DbContext
    {

		public PITCSurveyContext()
			: base()
		{
		}

		public PITCSurveyContext(String NameOrConnectionString)
			: base(NameOrConnectionString)
		{
		}

		public PITCSurveyContext(DbConnection Connection)
			: base(Connection, true)
		{
		}

		public DbSet<Volunteer> Volunteers { get; set; }

		public DbSet<Survey> Surveys { get; set; }
		public DbSet<SurveyQuestion> SurveyQuestions { get; set; }

		public DbSet<Question> Questions { get; set; }
		public DbSet<AnswerChoice> AnswerChoices { get; set; }
		public DbSet<SurveyNavigation> SurveyNavigation { get; set; }

		public DbSet<SurveyResponse> SurveyResponses { get; set; }
		public DbSet<SurveyResponseAnswer> SurveyResponseAnswers { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Question>().HasMany(q => q.AnswerChoices).WithMany().Map(m => m.ToTable("QuestionAnswerChoices"));

			modelBuilder.Entity<SurveyQuestion>().HasMany(q => q.DependentQuestionAnswers).WithMany().Map(m => m.ToTable("SurveyQuestionDependentAnswers"));
			modelBuilder.Entity<SurveyQuestion>().HasMany(q => q.Navigation).WithRequired(n => n.SurveyQuestion).Map(m => m.ToTable("SurveyQuestionNavigation")).WillCascadeOnDelete(false);

			modelBuilder.Entity<SurveyQuestion>().HasMany(q => q.Navigation).WithRequired(n => n.NextSurveyQuestion).WillCascadeOnDelete(false);
			modelBuilder.Entity<SurveyQuestion>().HasRequired(q => q.Question).WithMany().WillCascadeOnDelete(false);
			modelBuilder.Entity<SurveyQuestion>().HasRequired(q => q.Survey).WithMany(s => s.SurveyQuestions).WillCascadeOnDelete(false);
		}
	}
}

/*
 * pitcdb
 * PitcsurveyAdmin
 * XamarinRocks1
 * 
 */