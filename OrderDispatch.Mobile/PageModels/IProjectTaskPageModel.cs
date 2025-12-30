using CommunityToolkit.Mvvm.Input;
using OrderDispatch.Mobile.Models;

namespace OrderDispatch.Mobile.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}