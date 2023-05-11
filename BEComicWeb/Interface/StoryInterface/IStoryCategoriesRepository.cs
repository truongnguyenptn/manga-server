﻿using BEComicWeb.Model.StoryModel;

namespace BEComicWeb.Interface.StoryInterface
{
    public interface IStoryCategoriesRepository
    {
        public List<StoryCategories> getStoryCategories(Stories? story);
        public StoryCategories deleteStoryCategory(StoryCategories story_cate);
        public StoryCategories addStoryCategory(StoryCategories? story_cate);
    }
}
