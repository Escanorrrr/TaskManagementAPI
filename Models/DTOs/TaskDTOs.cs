using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models.DTOs;

public record CreateTaskDto(
    [Required][MaxLength(200)] string Title,
    string Description);

public record UpdateTaskDto(
    [Required][MaxLength(200)] string Title,
    string Description,
    bool IsCompleted);

public record TaskResponseDto(
    int Id,
    string Title,
    string Description,
    bool IsCompleted,
    DateTime CreatedAt); 