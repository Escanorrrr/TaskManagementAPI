using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models.DTOs;

public record RegisterDto(
    [Required][EmailAddress] string Email,
    [Required][MinLength(6)] string Password);

public record LoginDto(
    [Required][EmailAddress] string Email,
    [Required] string Password);

public record AuthResponseDto(
    string Token,
    string Email); 