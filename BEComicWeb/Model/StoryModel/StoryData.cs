﻿namespace BEComicWeb.Model.StoryModel
{
    public class StoryData
    {
        public Stories? Story { get; set; }
        public List<Authors>? StoryAuthorList { get; set; }
        public List<Categories>? StoryCategoryList { get; set; }
    }
}