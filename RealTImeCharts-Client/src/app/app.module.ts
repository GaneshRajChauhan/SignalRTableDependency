import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ChartsModule } from 'ng2-charts';
import { HttpClientModule } from '@angular/common/http';
import { GaugesChartComponent } from './charts/gaugeschart.component';
import { GoogleChartsBaseService } from './services/google-charts.base.service';
import { GoogleGaugesChartService } from './services/google-gauges-chart.service';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    GaugesChartComponent
  ],
  imports: [
    BrowserModule,
    ChartsModule,
    HttpClientModule
  ],
  providers: [GoogleChartsBaseService,GoogleGaugesChartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
