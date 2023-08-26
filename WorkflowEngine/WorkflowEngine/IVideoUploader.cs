namespace WorkflowEngine
{
    public interface IVideoUploader
    {
        void EncodeVideo(VideoFile videoFile);
        void UploadVideo(VideoFile videoFile);
        void DisplayStatus(VideoFile videoFile);
    }
}