using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FinalProject
{
    internal class ReportGenerator
    {
        private readonly Profile _profile;

        public ReportGenerator(Profile profile)
        {
            _profile = profile ?? throw new ArgumentNullException(nameof(profile));
        }

        public string GenerateReport()
        {
            if (_profile.DailyMetrics == null || !_profile.DailyMetrics.Any())
                return "No metrics logged. Please log metrics to generate a report.";

            var report = $"Health Report for {_profile.Name}\n\n";
            report += $"Target Weight: {_profile.TargetWeight} lbs\n";
            report += $"Target Calories: {_profile.TargetCaloriesConsumed} per day\n";
            report += $"Target Water Intake: {_profile.TargetWaterIntake} cups per day\n";
            report += $"Target Exercise Time: {_profile.TargetTimeExercised} minutes per day\n\n";

            // Analyze Metrics
            int daysBelowCalories = 0, daysBelowWater = 0, daysBelowExercise = 0;
            foreach (var metric in _profile.DailyMetrics)
            {
                if (metric.CaloriesConsumed < _profile.TargetCaloriesConsumed) daysBelowCalories++;
                if (metric.WaterIntake < _profile.TargetWaterIntake) daysBelowWater++;
                if (metric.TimeExercised < _profile.TargetTimeExercised) daysBelowExercise++;
            }

            // Weight Analysis
            var lastLoggedWeight = _profile.DailyMetrics.Last().Weight;
            if (lastLoggedWeight >= _profile.TargetWeight)
                report += $"Congratulations! You've achieved your weight goal of {_profile.TargetWeight} lbs.\n";
            else
                report += $"You did not meet your weight goal. Current weight is {lastLoggedWeight} lbs.\n";

            // Calories Analysis
            if (daysBelowCalories > 0)
                report += $"{daysBelowCalories} day(s) fell short of the daily calorie goal.\n";
            else
                report += "You met your calorie goal every day. Well done!\n";

            // Water Intake Analysis
            if (daysBelowWater > 0)
                report += $"{daysBelowWater} day(s) fell short of the daily water intake goal.\n";
            else
                report += "You met your water intake goal every day. Stay hydrated!\n";

            // Exercise Analysis
            if (daysBelowExercise > 0)
                report += $"{daysBelowExercise} day(s) fell short of the daily exercise goal.\n";
            else
                report += "You met your exercise goal every day. Keep it up!\n";

            return report;
        }

        public void SaveReportToFile(string filePath, string reportContent)
        {
            File.WriteAllText(filePath, reportContent);
        }
    }
}