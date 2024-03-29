import { Component } from "@angular/core";
import { Router, ActivatedRoute, ParamMap } from "@angular/router";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"],
})
export class AppComponent {
  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.route.queryParams.subscribe((params) => {
      this.name = params["name"];
    });
  }

  title = "physical-examination";
  name = "";
}
