﻿using System.Text.RegularExpressions;

using Microsoft.Recognizers.Text.Matcher;

namespace Microsoft.Recognizers.Text.DateTime.Italian
{
    public sealed class ItalianMergedParserConfiguration : ItalianCommonDateTimeParserConfiguration, IMergedParserConfiguration
    {

        public Regex BeforeRegex { get; }

        public Regex AfterRegex { get; }

        public Regex SinceRegex { get; }

        public Regex AroundRegex { get; }

        public Regex DateAfter { get; }

        public Regex YearRegex { get; }

        public IDateTimeParser SetParser { get; }

        public IDateTimeParser HolidayParser { get; }

        public StringMatcher SuperfluousWordMatcher { get; }

        public ItalianMergedParserConfiguration(IOptionsConfiguration options) : base(options)
        {
            BeforeRegex = ItalianMergedExtractorConfiguration.BeforeRegex;
            AfterRegex = ItalianMergedExtractorConfiguration.AfterRegex;
            SinceRegex = ItalianMergedExtractorConfiguration.SinceRegex;
            AroundRegex = ItalianMergedExtractorConfiguration.AroundRegex;
            DateAfter = ItalianMergedExtractorConfiguration.DateAfterRegex;
            YearRegex = ItalianDatePeriodExtractorConfiguration.YearRegex;
            SuperfluousWordMatcher = ItalianMergedExtractorConfiguration.SuperfluousWordMatcher;
            DatePeriodParser = new BaseDatePeriodParser(new ItalianDatePeriodParserConfiguration(this));
            TimePeriodParser = new BaseTimePeriodParser(new ItalianTimePeriodParserConfiguration(this));
            DateTimePeriodParser = new BaseDateTimePeriodParser(new ItalianDateTimePeriodParserConfiguration(this));
            SetParser = new BaseSetParser(new ItalianSetParserConfiguration(this));
            HolidayParser = new BaseHolidayParser(new ItalianHolidayParserConfiguration(this));
            TimeZoneParser = new DummyTimeZoneParser();
        }
    }
}
