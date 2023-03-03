using Models; 
using Services;

namespace Tests;

/*Run these to see test coverage*/
/* dotnet test --collect:"XPlat Code Coverage" */
/* reportgenerator -reports:"./TestResults/{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html */

public class TicketTests{
    [Fact]
    public void TicketShouldCreateValidTicket(){
        Ticket ticket = new();
        ticket.amount = 654.22M;
        ticket.submittedBy = 332211;
        ticket.description = "Hotel money";
        Assert.NotNull(ticket);
        Assert.False(ticket.amount == 0);
        Assert.Equal(654.22M, ticket.amount);
        Assert.Equal(332211, ticket.submittedBy);
        Assert.Equal("Hotel money", ticket.description);
        Assert.False(ticket.submittedBy == 0);
    }
}
