import { TestBed } from '@angular/core/testing';

import { CalculateService } from './calculate.service';

describe('CalculateService', () => {
  let service: CalculateService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculateService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
  it('should return 5', () => {
    const actual=service.Add(2,3);
    expect(5).toEqual(actual);
  });
  it('should return true', () => {
    const actual=service.IsEven(2);
    expect(actual).toBeTrue();
  });
  it('should return 6', () => {
    const actual=service.GetNos();
    expect(actual.length).toBeGreaterThan(0)
  });

});
